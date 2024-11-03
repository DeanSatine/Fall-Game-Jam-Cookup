using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorV2 : InteractableObjects
{

    bool IsOpen = false;

    public override void OnInteraction()
    {
        if (IsOpen)
        {
            //Load the right scene here
            print("LoadingV2! You did it!!!... again");
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

    public void Unlock()
    {
        IsOpen = true;
    }

    public override void UseItem(GameObject thing)
    {
        throw new System.NotImplementedException();
    }
}