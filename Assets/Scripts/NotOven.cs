using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotOven : InteractableObjects
{
    public override void OnInteraction()
    {
        //say voiceline here
        print("Fuck you");
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
