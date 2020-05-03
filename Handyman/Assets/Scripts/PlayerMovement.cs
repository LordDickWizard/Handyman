using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World!");
        rb.AddForce(0, 600, 500);
    }

    // Update is called once per frame for physics
    void FixedUpdate()
    {
        //rb.AddForce(0, 0, 800 * Time.deltaTime);
    }
}
