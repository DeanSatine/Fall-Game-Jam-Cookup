using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PlayerControllerV2 : MonoBehaviour
{

    public GameObject HoveredObject = null;
    public GameObject HeldObject = null;

    [SerializeField] private Transform HandPos;
    [SerializeField] private Camera cam;

    private bool IsHoldingSomething = false;

    private Rigidbody Body;
    private Transform Trans;

    private Vector3 MovDir;
    private int MoveSpeed = 5;

//    private Vector3 Turn = new Vector3(0, 75, 0);


// Start is called before the first frame update
void Start()
    {
        Body = GetComponent<Rigidbody>();
        Trans = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Body.velocity = MovDir.normalized * MoveSpeed;
    }

    private void FixedUpdate()
    {
        MovDir.x = Input.GetAxis("Horizontal");
        MovDir.z = Input.GetAxis("Vertical");

        //MovDir = cam.transform.forward.normalized * Input.GetAxis("Vertical");
        //MovDir += cam.transform.right.normalized * Input.GetAxis("Horizontal");

        if (Physics.Raycast(cam.ScreenPointToRay(Mouse.current.position.value), out RaycastHit hit))
        {
            transform.LookAt(new Vector3(hit.point.x, transform.position.y, hit.point.z));
        }

        if (Input.GetKey(KeyCode.F) && HoveredObject != null)
        {
            Interact();
        }
        if (Input.GetKey(KeyCode.Mouse0) && HoveredObject != null && IsHoldingSomething == false
            && (HoveredObject.name == "Cup" || HoveredObject.name == "Poster"))
        {
            PickUp();
            IsHoldingSomething = true;
            HeldObject = HoveredObject;
            print("Picking up");
        }
        if (Input.GetKey(KeyCode.Mouse1) && IsHoldingSomething == true)
        {
            PutBack();
            IsHoldingSomething = false;
            HeldObject = null;
            print("Putting down");
        }
/*
        if (Input.GetKey(KeyCode.E))
        {
            Trans.Rotate(Turn * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            Trans.Rotate(-Turn * Time.deltaTime);
        }
*/
    }

    //These are for the object interaction system
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Interactable" && other != HeldObject)
        {
            HoveredObject = other.gameObject;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == HoveredObject && IsHoldingSomething == false)
        {
            HoveredObject = null;
        }
    }


    //Interact with the hovered object
    private void Interact()
    {
        if (HeldObject != null)
        {
            HeldObject.GetComponent<InteractableObjects>().UseItem(HoveredObject);
        }
        else if (HoveredObject.name != "Sink")
        {
            HoveredObject.GetComponent<InteractableObjects>().OnInteraction();
        } 
    }

    private void PickUp()
    {
        if (HoveredObject.name == "Poster")
        {
            HoveredObject.GetComponent<Poster>().OnPickUp(HandPos);
        }
        else if (HoveredObject.name == "Cup")
        {
            HoveredObject.GetComponent<Cup>().OnPickUp(HandPos);
        }
    }

    private void PutBack()
    {
        if (HoveredObject.name == "Poster")
        {
            HoveredObject.GetComponent<Poster>().OnPutBack();
        }
        else if (HoveredObject.name == "Cup")
        {
            HoveredObject.GetComponent<Cup>().OnPutBack();
        }
    }
}
