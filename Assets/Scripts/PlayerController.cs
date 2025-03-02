using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    /*// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void onMove(InputValue movementValue)
    {

    }*/

    public Rigidbody rigidBody;

    /*public float forwardForce;
    public float sideWaysForce;
    public float rotationForce;*/

    private float forwardForce = 500;
    private float rotationForce = 100;

    void FixedUpdate()
    {
        if (Input.GetKey("d"))
        {
            transform.Rotate(0, rotationForce * Time.deltaTime, 0);
            //rigidBody.AddForce(sideWaysForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("a"))
        {
            transform.Rotate(0, -rotationForce * Time.deltaTime, 0);
            //rigidBody.AddForce(-sideWaysForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("w"))
        {
            rigidBody.AddForce(transform.forward * forwardForce * Time.deltaTime, ForceMode.Force);
            //rigidBody.AddForce(0, 0, forwardForce * Time.deltaTime);
        }

        if (Input.GetKey("s"))
        {
            rigidBody.AddForce(-transform.forward * forwardForce * Time.deltaTime, ForceMode.Force);
            //rigidBody.AddForce(0, 0, -forwardForce * Time.deltaTime);
        }
    }
}
