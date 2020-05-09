using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class updateScore : MonoBehaviour
{
    public Score score_scriptRef;

    public GameObject score_objRef;

    public Text scoreText;

    private int score;

    // Start is called before the first frame update
    void Start()
    {
        score_objRef = GameObject.FindWithTag("Score");
        score_scriptRef = score_objRef.GetComponent<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("e"))
        {
            score = score_scriptRef.getScore();
            scoreText.text = score.ToString();
        }
    }
}
