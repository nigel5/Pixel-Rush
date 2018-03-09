using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlPadScript : MonoBehaviour {

    Camera mCamera;
    int iColour = 0;
    Image image;

    Color[] colours = new Color[4] { Color.white, Color.red, Color.green, Color.blue };

	// Use this for initialization
	void Start () {
        mCamera = Camera.main;
        image = GetComponent<Image>();
        // Set scaling so that the control pad spans the width of the screen and correct height
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Space))
        {
            this.OnTap();
        }
	}

    void OnTap()
    {
        iColour += 1;
        image.color = colours[iColour];
        if (iColour >= colours.Length - 1)
        {
            iColour = 0;
        }
    }
}
