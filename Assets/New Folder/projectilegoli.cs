using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectilegoli : MonoBehaviour
{
    [SerializeField] private float speed = 10f;

    private void Update()
    {
        // Move the projectile forward
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the projectile hits a target with a "Target" tag
        if (other.CompareTag("Enemy"))
        {
            // Destroy the target object
            Destroy(other.gameObject);

            // Destroy the projectile
            Destroy(gameObject);
        }
    }
}