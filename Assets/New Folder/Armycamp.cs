using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armycamp : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth = 100;




    public void TakeDamage(int damageAmount)
    {
        // Reduce the enemy's health by the damage amount
        currentHealth -= damageAmount;

        // Check if the enemy's health is less than or equal to zero
        if (currentHealth <= 0)
        {
            Die(); // Call a method to handle the enemy's death
        }
    }

    private void Die()
    {
        // Handle enemy death, e.g., play death animation, spawn particles, or remove the GameObject
        Destroy(gameObject);
        Debug.Log("Army Camp Has Destroyed");
    }


}
