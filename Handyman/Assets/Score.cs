using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{

    public Rigidbody player;
    public Rigidbody interactionZone;

    private int score = 0;
    private int award = 1000;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        while(player.detectCollisions && interactionZone.detectCollisions)
        {
            if (Input.GetKey("e"))
            {
                score = score + award;
                Debug.Log(score);
            }
        }
    }
}
