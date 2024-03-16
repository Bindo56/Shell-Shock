using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sounddestroyer : MonoBehaviour
{
    AudioSource source;

    private void Awake()
    {
        source = GetComponent<AudioSource>();
    }


    private void start ()
    {
        StartCoroutine(WaitCoroutine());

    }

    IEnumerator WaitCoroutine()
    {
        yield return new WaitForSeconds(source.clip.length);
        Destroy(gameObject);
    }
}
