using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletScript : MonoBehaviour {

    public int damage;
    public int speed;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector2.up * Time.deltaTime * speed);
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (!coll.CompareTag("Player")) Destroy(gameObject);
    }
}
