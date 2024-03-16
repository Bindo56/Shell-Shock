using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletdamage : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float damage = 20f;

    private void Update()
    {
        // Move the projectile forward
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the projectile hits an enemy
        if (other.CompareTag("army"))
        {
            other.gameObject.SendMessage("TakeDamage", damage);
        }

        // Destroy the projectile
        Destroy(gameObject);
    }
}
