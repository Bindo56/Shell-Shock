using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class motarbullet : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletSpawnPoint;
    public float shootInterval;


    private void Start()
    {

        StartCoroutine(ShootRoutine());
    }

    private IEnumerator ShootRoutine()
    {

        yield return new WaitForSeconds(shootInterval);
        // Instantiate a bullet prefab at the bullet spawn point
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, Quaternion.identity);
        // Destroy the bullet after a few seconds to avoid clutter
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the entering collider has a specific tag (e.g., "Projectile")
        if (other.CompareTag("projectile"))
        {
            // Destroy the bullet when it collides with a projectile
            Destroy(gameObject);
        }

    }
}
