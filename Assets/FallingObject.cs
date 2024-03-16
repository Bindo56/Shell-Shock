using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObject : MonoBehaviour
{
    private Rigidbody rb;
    public float initialForce = 10f; // The initial force applied to the object
    public float accelerationRate = 2f; // Rate at which the force increases

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.down * initialForce, ForceMode.Impulse);
    }

    private void FixedUpdate()
    {
        // Increase the force over time to make it fall faster
        float currentForce = rb.velocity.y;
        rb.AddForce(Vector3.down * accelerationRate, ForceMode.Acceleration);
    }
}

