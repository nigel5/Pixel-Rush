using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public static class PlayerStats {
    static int lastScore = 0;
    static int highScore = 0;
    public static int LastScore
    {
        get
        {
            return lastScore;
        }
        set
        {
            lastScore = value;
        }
    }
    public static int Highscore
    {
        get
        {
            return highScore;
        }
        set
        {
            highScore = value;
            SaveAndLoad.Save();
        }
    }
}
