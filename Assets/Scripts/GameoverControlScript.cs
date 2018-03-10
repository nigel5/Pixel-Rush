using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameoverControlScript : MonoBehaviour {
    public Text score;
    public Text highscore;

    void Start()
    {
        // Load past highscore data
        SaveAndLoad.Load();
        score.text = "SCORE: " + PlayerStats.LastScore.ToString();
        highscore.text = "HIGHSCORE: " + PlayerStats.Highscore.ToString();
    }


    public void PlayAgain()
    {
        SceneManager.LoadScene(1);
    }
}
