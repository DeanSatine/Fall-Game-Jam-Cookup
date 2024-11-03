using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelmanager : MonoBehaviour
{
    public static bool isDoorOpen = false;
    public static bool isPosterGone = false;

    float time = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        if (time < 0)
        {
            time = 5.0f;
            if (isDoorOpen && isPosterGone)
            {
                print("You win!!!");
            }
        }
    }
}
