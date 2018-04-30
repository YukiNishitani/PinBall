using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScorePrint : MonoBehaviour {
    private GameObject ScoreText;

	void Start(){
        this.ScoreText = GameObject.Find("ScoreText");
	}

	// Update is called once per frame
	void Update () {
        		
	}
    public void UpdateScore(){
        GameObject ball = GameObject.Find("Ball");
        int score = ball.GetComponent<ScoreContriller>().Score;
        Debug.Log(score);
        this.GetComponent<Text>().text = "Score:" + (score);
    }
}
