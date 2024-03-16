using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int maxHealth = 200;
    public int currentHealth = 200;
    public HealthBar healthBar;



    private void Start()
    {
        currentHealth = maxHealth; // Initialize current health to max health.
        if (healthBar != null)
        {
            healthBar.SetMaxHealth(maxHealth);

        }
    }




    public void TakeDamage(int damageAmount)
    {
        
        currentHealth -= damageAmount;

        
        if (currentHealth <= 0)
        {
            
            Die();

            
        }

        UpdateHealthBar();
    }

    private void Die()
    {
      
        Destroy(gameObject);
    }


    private void UpdateHealthBar()
    {
        if (healthBar != null)
        {
            healthBar.SetHealth(currentHealth);
        }
    }
}



