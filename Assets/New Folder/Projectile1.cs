using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class Projectile1 : MonoBehaviour
{
    public UnityEvent OnHit = new UnityEvent();

    
    public int damage = 10;

    private void OnCollisionEnter2D( Collision2D other)
    {
        OnHit?.Invoke();
        Enemy enemy = other.transform.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
            Destroy(gameObject);
        }

    }

}
