using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class armyfollowbullet : MonoBehaviour
{
    public Transform player;  // Reference to the player's Transform component.
    public float moveSpeed = 5f;
    [SerializeField] private float damage = 30f;




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
        if (other.CompareTag("Camp"))
        {
            other.gameObject.SendMessage("TakeDamage", damage);
        }

    }

 

   


}
