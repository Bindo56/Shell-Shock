using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class campdestroyerprojectile : MonoBehaviour
{
    // Start is called before the first frame update


    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private float _speed = 40f;
    public float maxDistance = 20;

    private Vector2 startPosition;
    private float conquaredDistance = 20;
    public int damage = 10;

    public void Init(Vector2 dir)
    {
        _rb.velocity = dir * _speed;
        startPosition = transform.position;
    }

    private void OncollisionEnter2D(Collision2D col)
    {

        Armycamp Armycamp = col.transform.GetComponent<Armycamp>();
        if (Armycamp != null)
        {
            Armycamp.TakeDamage(damage);
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
    private void OnCollisionEnter(Collision collision)
    {

        Destroy(gameObject);
    }

    private void DisableObject()
    {
        _rb.velocity = Vector2.zero;
        gameObject.SetActive(false);
    }

}
