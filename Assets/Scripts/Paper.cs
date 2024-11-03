using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Paper : MonoBehaviour
{
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        rb.AddTorque(rb.velocity * Time.deltaTime * 3000);
        rb.AddTorque(transform.right * Time.deltaTime * 3000);
        rb.AddTorque(-transform.up * Time.deltaTime * 3000);
        rb.AddForce(transform.right * Time.deltaTime, ForceMode.Force);
        rb.centerOfMass = -rb.velocity.normalized;
        if (Random.Range(0, 300) == 2) rb.AddForce(Vector3.up * 0.8f, ForceMode.Force);

        if (rb.velocity.magnitude > 10) rb.velocity = rb.velocity.normalized * 10;

        //rb.mass = Mathf.Clamp(Mathf.Tan(Time.deltaTime * 100), 0.1f, 0.4f);

    }
}
