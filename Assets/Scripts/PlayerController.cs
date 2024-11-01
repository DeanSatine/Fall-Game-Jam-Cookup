using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody Body;

    private Vector3 MovDir;
    private int MoveSpeed = 5;

    // Start is called before the first frame update
    void Start()
    {
        Body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Body.velocity = MovDir * MoveSpeed;
    }

    private void FixedUpdate()
    {
        MovDir.x = Input.GetAxis("Horizontal");
        MovDir.z = Input.GetAxis("Vertical");
    }


}
