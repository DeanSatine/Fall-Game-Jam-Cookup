using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorV3 : InteractableObjects
{

    bool IsOpen = false;
    [SerializeField] NextScene manager;

    public override void OnInteraction()
    {
        if (IsOpen)
        {
            levelmanager.isDoorOpen = true;
            print("Did you get the poster?");
            manager.DOTHETHING();
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

    public bool GetOpened()
    {
        return IsOpen;
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
