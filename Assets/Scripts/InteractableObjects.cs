using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InteractableObjects : MonoBehaviour
{
    public abstract void OnInteraction();

    public abstract void UseItem(GameObject thing);

    public abstract void OnPickUp(Transform offset);

    public abstract void OnPutBack();
};
