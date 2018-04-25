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
        this.scoreText = GameObject.Find("Ball");
        this.scoreText.GetComponent<Text>().text = "Score:" + (Score);		
	}
}
