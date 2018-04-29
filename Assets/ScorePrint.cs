using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScorePrint : MonoBehaviour {
    private GameObject scoreText;

	void Start(){
        this.scoreText = GameObject.Find("ScoreText");
	}

	// Update is called once per frame
	void Update () {
        		
	}
    public void UpdateScore(){
        GameObject ball = GameObject.Find("Ball");
        int score = ball.GetComponent<ScoreContriller>().Score;
        ball.GetComponent<Rigidbody>().useGravity = false;
        this.GetComponent<Rigidbody>().useGravity = false;
        Debug.Log(score);
        this.GetComponent<Text>().text = "Score:" + (score);
    }
}
