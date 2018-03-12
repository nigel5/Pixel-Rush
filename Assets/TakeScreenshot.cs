using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeScreenshot : MonoBehaviour {

    public string filename;

	// Use this for initialization
	void Start () {
        Debug.Log("Screenshot service waiting... Right click to save screenshot to root folder of this project...");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("took screenshot");
            ScreenCapture.CaptureScreenshot(filename + ".png");
        }
	}
}
