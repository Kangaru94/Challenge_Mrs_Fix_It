using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private float speed = 15f;
    private float fastSpeed;
    private float rotationSpeed;
    private float verticalInput;

    void Start()
    {

    }

    void FixedUpdate()
    {
       //fastSpeed is the throttle
       //rotateSpeed controls rate of plane's turn
        fastSpeed = speed + 20f;
        rotationSpeed = 100f;

        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        //if statement controls throttle based on space bar
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * fastSpeed);
        }

        //this is the default speed of forward motion
        else 
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }

        //rotates the plane 
        transform.Rotate(Vector3.right * Time.deltaTime * rotationSpeed * verticalInput);
    }
}
