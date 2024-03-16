using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootinterval : MonoBehaviour
{

    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private float _speed = 40f;
    public float maxDistance = 20;

    private Vector2 startPosition;
    private float conquaredDistance = 20;
    public int damage = 10;
    [SerializeField] private Transform _spawnPoint;
    public float shootInterval;
    [SerializeField] private Projectile _projectilePrefab;

    private void Start()
    {

        StartCoroutine(ShootRoutine());
    }

    private IEnumerator ShootRoutine()
    {

        yield return new WaitForSeconds(shootInterval);
        // Instantiate a bullet prefab at the bullet spawn point
        Instantiate(_projectilePrefab, _spawnPoint.position, Quaternion.identity).Init(transform.up);
        // Destroy the bullet after a few seconds to avoid clutter

    }

    public void Init(Vector2 dir)
    {
        _rb.velocity = dir * _speed;
        startPosition = transform.position;

    }



    private void OncollisionEnter2D(Collision2D col)
    {

        Enemy enemy = col.transform.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }

        Destroy(gameObject);
    }

    private void Update()
    {
        conquaredDistance = Vector2.Distance(transform.position, startPosition);
        if (conquaredDistance >= maxDistance)
        {
            DisableObject();
        }

    }


    private void DisableObject()
    {
        _rb.velocity = Vector2.zero;
        gameObject.SetActive(false);
    }

}
