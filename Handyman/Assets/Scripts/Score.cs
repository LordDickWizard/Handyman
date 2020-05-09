using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private GameObject player;
    private int score;
    private SphereCollider interactionSphere;
    //bool to detect if collided with player
    private bool isCollided;
    Camera camera;
    Vector3 playerPosition;
    playerCollision playerCollision;

    void Start()
    {
        //possibly change this to use a camera only focused on goal object to keep things decoupled
        camera = Camera.main;
        score = 1000;
        player = GameObject.FindGameObjectWithTag("Player");
        playerPosition = player.transform.position;
        isCollided = false;
        interactionSphere = gameObject.GetComponent<SphereCollider>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("e"))
        {
            Ray ray = camera.ScreenPointToRay(playerPosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                //change this to use gameobject.getcomponent no need to create public gameobject of object
                Interactable interactable = gameObject.GetComponent<Collider>().GetComponent<Interactable>();
                if (interactable != null && isCollided == true)
                {
                    score += 100;
                    Debug.Log(score);
                    Debug.Log("we hit " + hit.collider.name + "position: " + hit.point);
                }
            }
            isCollided = false;
            Debug.Log(score);
        }
    }

    public int getScore()
    {
        return score;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            isCollided = true;
        }
        else
        {
            isCollided = false;
        }
    }
}