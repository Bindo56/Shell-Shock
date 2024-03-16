
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class damage : MonoBehaviour
{
   
    public int maxHealth = 100; // Maximum health points.
    public int currentHealth;   // Current health points.
    public HealthBar healthBar;

    private void Start()
    {
        currentHealth = maxHealth; 
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
            Debug.Log("dead");
            SceneManager.LoadScene("GameOver");

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
