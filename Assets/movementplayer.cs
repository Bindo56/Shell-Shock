using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movementplayer : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float rotationSpeed = 1000.0f;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");

        float horizontalInput = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(moveSpeed * verticalInput,  horizontalInput * moveSpeed);


       


        float rotation = horizontalInput * rotationSpeed * Time.deltaTime;
        rb.angularVelocity = rotation;
    }
}