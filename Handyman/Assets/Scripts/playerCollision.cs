using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour
{

    public PlayerMovement movement;

    public Collision interactionObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void addScore()
    {

    }

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log(collisionInfo.collider.name);
            movement.enabled = false;
        }
        if (collisionInfo.collider.tag == "Score")
        {
            if (Input.GetKey("e"))
            {

            }
        }
    }
}
