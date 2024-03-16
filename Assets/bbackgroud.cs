using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bbackgroud : MonoBehaviour
{
    float leftx = -18.24f, rightx = 18.24f;
    public float speed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = new Vector2(transform.position.x - speed, transform.position.y);
        if(transform.position.x < leftx)
            transform.position = new Vector2(rightx, transform.position.y);
    }
}
