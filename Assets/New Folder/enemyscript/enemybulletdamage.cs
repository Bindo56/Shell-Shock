using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemybulletdamage : MonoBehaviour
{
    public int damage = 10;
   

    private void OnCollisionEnter2D(Collision2D col)
    {
        // Check if the collided object has a Camp component.
        Enemy enemy = col.transform.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);


            Destroy(gameObject);
        }
        // Destroy the bullet.
       
    }
}