using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float horizontalForce = 500f;
    public float verticalForce = 500f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World!");
        //rb.AddForce(0, 600, 500);
    }

    // Update is called once per frame for physics
    void FixedUpdate()
    {
        //rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if(Input.GetKey("d"))
        {
            rb.AddForce(horizontalForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-horizontalForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, verticalForce * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -verticalForce * Time.deltaTime, ForceMode.VelocityChange);
        }
    }
}
