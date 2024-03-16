using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectiledamage : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    [SerializeField] private float damage = 30f;

    private void Update()
    {
        // Move the projectile forward
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the projectile hits an enemy
        if (other.CompareTag("Enemy"))
        {
            other.gameObject.SendMessage("TakeDamage", damage);
        }

        // Destroy the projectile
        Destroy(gameObject);
    }
}