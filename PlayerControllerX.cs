using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private float speed = 15f;
    private float fastSpeed;
    private float rotationSpeed = 100f;
    private float verticalInput;
    private float horizontalInput;

    void Start()
    {

    }

    void FixedUpdate()
    {
       // FastSpeed is the throttle
        fastSpeed = speed + 20f;

        // The horizontal input is moreso just to see if I could. I didn't ask "should I", I asked "can I" and yes, I can
        // Get the user's vertical and horizontal input
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");


        // If statement controls throttle based on space bar
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * fastSpeed);
        }

        // This is the default speed of forward motion
        else 
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }

        // Rotates the plane 
        transform.Rotate(Vector3.right * Time.deltaTime * rotationSpeed * verticalInput);
        transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed * horizontalInput);
    }
}
