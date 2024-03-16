using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // The object the camera should follow
    public float smoothSpeed = 0.125f; // How smoothly the camera should follow the target
    public Vector3 offset; // The offset from the target position

    void LateUpdate()
    {
        if (target == null)
        {
            return;
        }

        // Calculate the desired position for the camera
        Vector3 desiredPosition = target.position + offset;

        // Use SmoothDamp to interpolate between the current position and the desired position
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // Set the camera's position to the smoothed position
        transform.position = smoothedPosition;
    }
}
