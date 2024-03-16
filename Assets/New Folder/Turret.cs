using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Turret : MonoBehaviour
{
    private Camera _cam;
    [SerializeField, Range(1, 50)] private float _rotationSpeed = 1;
    [SerializeField] private Projectile _projectilePrefab;
    [SerializeField] private Transform _spawnPoint;
    private Collider2D[] tankColliders;
    public UnityEvent OnShoot;

    private void Awake()
    {
        _cam = Camera.main;
        tankColliders = GetComponentsInParent<Collider2D>();
    }

    void Update()
    {
        for (int i = 0; i < Input.touchCount; i++)
        {
            Touch touch = Input.GetTouch(i);
            Vector3 touchPosition = _cam.ScreenToWorldPoint(touch.position);
            touchPosition.z = 0;

            var dir = touchPosition - transform.position;
            transform.up = Vector2.MoveTowards(transform.up, dir, _rotationSpeed * Time.deltaTime);

            if (touch.phase == TouchPhase.Began)
            {
                Instantiate(_projectilePrefab, _spawnPoint.position, Quaternion.identity).Init(transform.up);

                foreach (var collider in tankColliders)
                {
                    Physics2D.IgnoreCollision(_projectilePrefab.GetComponent<Collider2D>(), collider);
                }

                OnShoot?.Invoke();
            }
        }
    }
}
