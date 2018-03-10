using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletScript : MonoBehaviour {

    ScoreboardScript sb;
    public int damage;
    public int speed;
	
    void Start()
    {
        sb = GameObject.FindWithTag("Scoreboard").GetComponent<ScoreboardScript>(); 
    }

	// Update is called once per frame
	void Update () {
        transform.Translate(Vector2.up * Time.deltaTime * speed);
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (!coll.CompareTag("Player") && !coll.CompareTag("PlayerHitbox"))
        {
            sb.IncreaseScore();
            Destroy(gameObject);
        }
    }
}
