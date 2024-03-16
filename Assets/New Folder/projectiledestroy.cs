using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectiledestroy : MonoBehaviour
{
    [SerializeField] private float speed = 10f;

    private void Update()
    {
        // Move the projectile forward
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Destroy the projectile when it collides with any object
        Destroy(gameObject);
    }
}