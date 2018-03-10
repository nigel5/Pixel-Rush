using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreboardScript : MonoBehaviour {

    EnemySpawnerScript enemySpawner;
    Text scoreText;
    public int currentScore = 0;

	// Use this for initialization
	void Start () {
        enemySpawner = GameObject.Find("EnemySpawner").GetComponent<EnemySpawnerScript>();
        scoreText = GetComponent<Text>();
        scoreText.text = currentScore.ToString();	
	}

    public void PlayerIsDead()
    {
        if (currentScore > PlayerStats.Highscore)
        {
            PlayerStats.Highscore = currentScore;
        }
        PlayerStats.LastScore = currentScore;
        SceneManager.LoadScene(2);
    }

    public void IncreaseScore()
    {
        // After every 10th increase, speed up the spawning interval
        if (currentScore % 10 == 0)
        {
            enemySpawner.IncreaseSpawningSpeed();
        }

        currentScore += 1;
        scoreText.text = currentScore.ToString();
    }
}
