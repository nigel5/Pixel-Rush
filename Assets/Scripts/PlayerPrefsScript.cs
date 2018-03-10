using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsScript : MonoBehaviour {
    public UnityEngine.UI.Toggle soundToggle;
    void Start()
    {
        // Set initial state of UI based on PlayerPrefs
        soundToggle.isOn = PlayerPrefs.GetInt("Audio") == 1 ? true : false;
    }
    public void ToggleAudio(UnityEngine.UI.Toggle toggle)
    {
        AudioListener.volume = toggle.isOn ? 1 : 0;
        PlayerPrefs.SetInt("Audio", toggle.isOn ? 1 : 0);
    }
}
