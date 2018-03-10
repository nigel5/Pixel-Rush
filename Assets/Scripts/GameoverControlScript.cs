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
        score.text = PlayerStats.lastScore.ToString();
        highscore.text = PlayerStats.highscore.ToString();
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(0);
    }
}
