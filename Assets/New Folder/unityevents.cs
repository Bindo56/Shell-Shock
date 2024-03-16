using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class unityevents : MonoBehaviour
{
    public UnityEvent OnHit = new UnityEvent();


    private void OnTriggerEnter2D(Collider2D collision)
    {
        OnHit.Invoke();
    }



    
}
