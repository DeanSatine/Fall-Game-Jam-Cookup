using FMODUnity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Insult : MonoBehaviour
{
    private StudioEventEmitter player;
    public float timer = 0;

    void Start()
    {
        player = GetComponent<StudioEventEmitter>();
        timer = Random.RandomRange(30.0f, 50.0f);
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            player.Play();
            timer = Random.RandomRange(30.0f, 50.0f);
        }
    }
}
