using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    private SceneManager manager = new SceneManager();
    public void SetScene(string to)
    {
        manager.SetScene(to);
    }
}
