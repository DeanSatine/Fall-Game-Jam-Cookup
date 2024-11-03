using FMODUnity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sink : InteractableObjects
{

    [SerializeField] GameObject Door;

    private StudioEventEmitter tick;

    private bool IsTooHot = true;

    public override void OnInteraction()
    {
        if (IsTooHot)
        {
            IsTooHot = false;
            print("Im too hot");
        }
        else
        {
            Door.GetComponent<Door>().Unlock();
            print("You hear a click");
        }
        tick.Play();
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
