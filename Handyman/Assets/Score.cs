using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{

    public BoxCollider player;
    public SphereCollider interactionZone;

    private int score = 0;
    private int award = 1000;

    // Start is called before the first frame update
    void Start()
    {

    }

// Update is called once per frame
    void Update()
    {
        Debug.Log(score);
    }

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Player")
        {
            Debug.Log(collisionInfo.collider.name);
            if (Input.GetKey("e"))
            {
                score = score + award;
                Debug.Log(score);
            }
        }
    }
}