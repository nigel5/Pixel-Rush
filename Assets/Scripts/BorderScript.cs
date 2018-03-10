using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderScript : MonoBehaviour {

    ScoreboardScript ss;

    // Use this for initialization
    void Start () {
        ss = GameObject.Find("Canvas").GetComponent<ScoreboardScript>();

    }
}
