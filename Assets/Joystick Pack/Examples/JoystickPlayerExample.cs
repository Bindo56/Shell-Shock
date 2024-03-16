using UnityEngine;

public class JoystickPlayerExample : MonoBehaviour
{
    public float speed;
    public VariableJoystick Joystick;
    public Rigidbody2D rb;
    public Transform playerFace; // Reference to the player's face Transform.
    public float rotationOffset = 0f; // Offset angle to change the rotation

    public void FixedUpdate()
    {
        rb.velocity = new Vector2(Joystick.Horizontal * speed, Joystick.Vertical * speed);


        float angle = Mathf.Atan2(Joystick.Vertical, Joystick.Horizontal) * Mathf.Rad2Deg + rotationOffset;

       
        playerFace.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
    }
}