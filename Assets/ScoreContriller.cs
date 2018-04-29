using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreContriller : MonoBehaviour{
    public int Score = 0;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision other)
    {
        if (other.transform.tag == "SmallStarTag")
        {
            Score += 100;
        }
        else if (other.transform.tag == "LatgeStarTag")
        {
            Score += 200;
        }
        else if (other.transform.tag == "SmallCloudTag")
        {
            Score += 50;
        }
        else if (other.transform.tag == "LargeCloudTag")
        {
            Score += 100;
        }
        GameObject scorePrint = GameObject.Find("ScoreText");
        scorePrint.GetComponent<ScorePrint>().UpdateScore();

    }
}