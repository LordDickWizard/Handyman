using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float horizontalForce = 10f;
    public float verticalForce = 10f;

    // Update is called once per frame for physics
    void FixedUpdate()
    {

        if(Input.GetKey("d"))
        {
            GetComponent<Rigidbody>().AddForce(horizontalForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            GetComponent<Rigidbody>().AddForce(-horizontalForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("w"))
        {
            GetComponent<Rigidbody>().AddForce(0, 0, verticalForce * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey("s"))
        {
            GetComponent<Rigidbody>().AddForce(0, 0, -verticalForce * Time.deltaTime, ForceMode.VelocityChange);
        }
    }
}
