using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyincomingpro : MonoBehaviour
{
    // This method is called when a collision occurs.
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
