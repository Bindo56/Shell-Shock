using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followscript : MonoBehaviour
{
    public Transform player;  // Reference to the player's Transform component.
    public float moveSpeed = 5f;  // Speed at which the AI follows the player.




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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collision involves the player (assuming the player has a specific tag, e.g., "Player").
        if (collision.gameObject.CompareTag("Player"))
        {
            // Destroy the game object that collided with the player.
            Destroy(gameObject);
        }
    }


}





