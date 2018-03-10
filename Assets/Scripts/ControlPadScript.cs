using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlPadScript : MonoBehaviour {

    public GameObject playerBullet;
    Camera mCamera;
    int iColour = 0;
    Image image;
    Color[] colours = new Color[4] { Color.white, Color.red, Color.green, Color.blue };

	// Use this for initialization
	void Start () {
        mCamera = Camera.main;
        image = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
        // Touch controls
        for (int i = 0; i < Input.touchCount; i++ )
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                Vector3 touchPos = Input.GetTouch(i).position;
                touchPos.z = 5;
                touchPos.y = 0.5F;
                Instantiate(playerBullet, mCamera.ScreenToWorldPoint(touchPos), Quaternion.identity, null);
                OnTap(Input.GetTouch(i).position);
            }
        }
	}

    void OnTap(Vector3 fingerPos)
    {
        iColour += 1;
        image.color = colours[iColour];
        if (iColour >= colours.Length - 1)
        {
            iColour = 0;
        }
    }
}
