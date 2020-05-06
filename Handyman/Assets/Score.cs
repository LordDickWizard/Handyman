using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform playerGameObject;
    public Text scoreText;

    private int score = 0;
    private int award = 1000;

    // Start is called before the first frame update
    void Start()
    {

    }

// Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
    }

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Player")
        {
            Debug.Log(collisionInfo.collider.name);
            if (Input.GetKey("e"))
            {
                score += award;
            }
        }
    }
}