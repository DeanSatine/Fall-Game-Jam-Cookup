using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    [SerializeField] string to;

    public void DOTHETHING()
    {
        SceneManager.LoadScene(to);
    }

}
