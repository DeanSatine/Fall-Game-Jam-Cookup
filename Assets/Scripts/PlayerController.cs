using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private GameObject HoveredObject = null;

    private Rigidbody Body;

    private Vector3 MovDir;
    private int MoveSpeed = 5;

    // Start is called before the first frame update
    void Start()
    {
        Body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Body.velocity = MovDir * MoveSpeed;
    }

    private void FixedUpdate()
    {
        MovDir.x = Input.GetAxis("Horizontal");
        MovDir.z = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.E) && HoveredObject != null)
        {
            Interact();
        }
        if (Input.GetKey(KeyCode.F) && HoveredObject != null)
        {
            PickUp();
        }

    }

    //These are for the object interaction system
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Interactable")
        {
            HoveredObject = other.gameObject;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == HoveredObject)
        {
            HoveredObject = null;
        }
    }


    //Interact with the hovered object
    private void Interact()
    {
        HoveredObject.GetComponent<InteractableObjects>().OnInteraction();
    }

    private void PickUp()
    {
        HoveredObject.GetComponent<InteractableObjects>().OnPickUp();
    }

}
