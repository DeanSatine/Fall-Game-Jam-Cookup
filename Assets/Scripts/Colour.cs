using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colour : InteractableObjects
{
    [SerializeField] GameObject Door;

    bool IsFound = true;

    public override void OnInteraction()
    {
        if (IsFound)
        {
            IsFound = false;
            print("You found me");
            Door.GetComponent<DoorV3>().Unlock();
            print("You hear a click");
        }
    }

    public override void OnPickUp(Transform offset)
    {
        throw new System.NotImplementedException();
    }

    public override void OnPutBack()
    {
        throw new System.NotImplementedException();
    }

    public override void UseItem(GameObject thing)
    {
        throw new System.NotImplementedException();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
