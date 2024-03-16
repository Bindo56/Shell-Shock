using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemybullet : MonoBehaviour
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
        Destroy(gameObject, 0.2f);
    }
}