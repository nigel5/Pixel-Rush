using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreboardScript : MonoBehaviour {

    Text scoreText;
    public int currentScore = 0;

	// Use this for initialization
	void Start () {
        scoreText = GetComponent<Text>();
        scoreText.text = currentScore.ToString();	
	}

    public void IncreaseScore()
    {
        currentScore += 1;
        scoreText.text = currentScore.ToString();
    }
}
