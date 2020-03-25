using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float maxSpeed;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Keyboard-controlled movement
        if (Input.GetKey("w"))
        {
            rb.AddForce(0f, 0f, 5000 * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0f, 0f, -5000 * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(5000 * Time.deltaTime, 0f, 0f);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-5000 * Time.deltaTime, 0f, 0f);
        }

        // Maximum velocity enforcement
        if (Vector3.Magnitude(rb.velocity) > maxSpeed)
        {
            Vector3 newVelocity = maxSpeed * rb.velocity.normalized;
            rb.velocity = newVelocity;
        }
    }
}
