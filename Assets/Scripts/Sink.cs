using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sink : InteractableObjects
{

    [SerializeField] GameObject Door;

    private bool IsTooHot = true;

    public override void OnInteraction()
    {
        if (IsTooHot)
        {
            IsTooHot = false;
        }
        else
        {
            Door.GetComponent<Door>().Unlock();
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
}
