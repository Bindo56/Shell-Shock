using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemydamagetake : MonoBehaviour
{
    public int damageAmount = 50; // Amount of damage the enemy deals to the player.

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collision is with the player.
        if (collision.gameObject.CompareTag("Player"))
        {
            // Get the PlayerHealth component from the player GameObject.
            damage damage = collision.gameObject.GetComponent<damage>();

            // Check if the playerHealth variable is not null.
            if (damage != null)
            {
                // Deal damage to the player.
                damage.TakeDamage(damageAmount);
            }
        }


    }

}









