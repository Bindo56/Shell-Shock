using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class campdestroyer : MonoBehaviour
{

    float destoryDelay = 0.00001f;
    public int damage = 10;




    private void OnCollisionEnter2D(Collision2D other)
    {

        Armycamp Armycamp = other.transform.GetComponent<Armycamp>();
        if (Armycamp != null)
        {
            Armycamp.TakeDamage(damage);
        }

        Destroy(gameObject);
    }
}
