using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class motarfollowscript : MonoBehaviour
{
    public Transform player;  // Reference to the player's Transform component.
    public float moveSpeed = 5f;  // Speed at which the AI follows the player.
    [SerializeField] private float damage = 10f;




    private void Update()
    {
        if (player != null)
        {
            // Calculate the direction from AI to the player.
            Vector3 direction = player.position - transform.position;

            // Normalize the direction vector to get a unit vector.
            direction.Normalize();

            // Move the AI in the direction of the player.
            transform.Translate(direction * moveSpeed * Time.deltaTime);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the projectile hits an enemy
        if (other.CompareTag("Player"))
        {
            other.gameObject.SendMessage("TakeDamage", damage);
            Destroy(gameObject);
        }

    }

   
    
}
