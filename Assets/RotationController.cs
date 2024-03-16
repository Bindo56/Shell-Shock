using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RotationController : MonoBehaviour, IDragHandler
{
    public float rotationSpeed = 5f;

    public void OnDrag(PointerEventData eventData)
    {
        float rotation = -eventData.delta.x * rotationSpeed;
        transform.Rotate(Vector3.forward, rotation);
    }
}