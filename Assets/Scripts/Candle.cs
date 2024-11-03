using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candle : InteractableObjects
{
    [SerializeField] GameObject Door;


    public override void OnInteraction()
    {
        if (Door.GetComponent<DoorV3>().GetOpened())
        {
            //Put line here
            print("Need a poster");
        }
        else if (Door.GetComponent<DoorV3>().GetOpened() == false)
        {
            //Put a line here
            print("This is a candle");
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
