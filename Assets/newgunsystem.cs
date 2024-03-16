using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class newgunsystem : MonoBehaviour
{
    private Camera _cam;
    [SerializeField, Range(1, 50)] private float _rotationSpeed = 1;
    [SerializeField] private Projectile _projectilePrefab;
    [SerializeField] private Transform _spawnPoint;
    
    public UnityEvent OnShoot;





    private void Awake()
    {
        _cam = Camera.main;
        

    }


    void Update()

    {
       
        

        
        {
            //Instantiate(_projectilePrefab, _spawnPoint.position, Quaternion.identity).Init(transform.up);
            Instantiate(_projectilePrefab, _spawnPoint.position, Quaternion.identity).Init(transform.up);

            

            OnShoot?.Invoke();
        }
    }

}
