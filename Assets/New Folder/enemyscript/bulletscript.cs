using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletscript : MonoBehaviour
{
    private GameObject army;
    private Rigidbody2D rb;
    public float force;

    void start()
    {
        rb = GetComponent<Rigidbody2D>();
        army = GameObject.FindGameObjectWithTag("army");

        Vector3 direction = army.transform.position - transform.position;
        rb.velocity = new Vector2(direction.x, direction.y).normalized * force;


    }
}
