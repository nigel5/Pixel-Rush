using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public static class SaveAndLoad
{
    static GameData gameData;
    public static int highscore;

    public static void Save()
    {
        gameData = new GameData
        {
            highscore = PlayerStats.Highscore
        };
        BinaryFormatter bf = new BinaryFormatter();
        FileStream fs = File.Create(Application.persistentDataPath + "/data.dat");
        bf.Serialize(fs, gameData);
        fs.Close();
    }

    public static void Load()
    {
        if (File.Exists(Application.persistentDataPath + "/data.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = File.Open(Application.persistentDataPath + "/data.dat", FileMode.Open);
            gameData = (GameData)bf.Deserialize(fs);
            fs.Close();

            PlayerStats.Highscore = gameData.highscore;
        }
        else
        {
            PlayerStats.Highscore = 0;
        }
    }
}

[System.Serializable]
public class GameData
{
    public int highscore;
}
