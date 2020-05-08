using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameObject player;
    public Collision interactionObject;
    private int score;
    Camera camera;
    Vector3 playerPosition;
    playerCollision playerCollision;

    private void Start()
    {
        //possibly change this to use a camera only focused on goal object to keep things decoupled
        camera = Camera.main;
        playerPosition = player.transform.position;
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
                Interactable interactable = interactionObject.collider.GetComponent<Interactable>();
                if (interactable != null)
                {
                    score += 100;
                    Debug.Log(score);
                    Debug.Log("we hit " + hit.collider.name + "position: " + hit.point);
                }
            }

            Debug.Log(score);
        }
    }
}