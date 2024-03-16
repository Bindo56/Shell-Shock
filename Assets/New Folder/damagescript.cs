using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damagescript : MonoBehaviour
{
    [SerializeField] private GameObject _explodePrefab;
    [SerializeField] private float maxHealth = 100f;
    private float currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Instantiate(_explodePrefab, transform.position, Quaternion.Euler(90, 0, 0));
        Destroy(gameObject);
    }
}




