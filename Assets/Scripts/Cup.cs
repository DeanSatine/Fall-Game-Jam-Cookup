using System.Collections;
using System.Collections.Generic;
using System.Net.Security;
using Unity.VisualScripting;
using UnityEngine;

public class Cup : InteractableObjects
{

    private Vector3 PutBackOffset = new Vector3(0, 0, 0);

    private Transform Hand = null;

    private Transform ThisPos;

    private bool IsHeld = false;
    private bool IsFull = false;


    // Start is called before the first frame update
    void Start()
    {
        ThisPos = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Hand != null)
        {
            ThisPos.position = Vector3.Lerp(ThisPos.position, Hand.position, 0.2f);
            ThisPos.rotation = Quaternion.Slerp(ThisPos.rotation, Hand.rotation, 0.1f);
        }
    }

    public override void UseItem(GameObject thing)
    {
        if (IsHeld && thing.name == "Toilet")
        {
            IsFull = true;
        }
        else if (IsHeld && thing.name == "Sink" && IsFull)
        {
            thing.GetComponent<InteractableObjects>().OnInteraction();
        }
    }

    public override void OnInteraction()
    {
        throw new System.NotImplementedException();
    }

    public override void OnPickUp(Transform offset)
    {
        PutBackOffset = offset.position - ThisPos.position;
        Hand = offset;
        IsHeld = true;
    }

    public override void OnPutBack()
    {
        Hand = null;
        ThisPos.position += PutBackOffset;
        IsHeld = false;
    }
}
