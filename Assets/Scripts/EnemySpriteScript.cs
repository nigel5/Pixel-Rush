using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpriteScript : MonoBehaviour {

	public int health;
	float speed;
    ScoreboardScript sb;

    // 1: Straight down
    // 2: Diagonal
    // 3: Crazy
    public int movementType;
	Vector2 movementDir;

	public bool canShoot;
	public int damage;

	// Use this for initialization
	void Start () {
        speed = Random.Range(5.0F, 10.0F);
        health = Random.Range(1, 4);
        sb = GameObject.FindWithTag("Scoreboard").GetComponent<ScoreboardScript>();

        if (movementType == 1) {
			movementDir = Vector2.down;
		}
		else
        {
            // TODO implement different movement types
            movementDir = Vector2.down;
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (health <= 0)
        {
            sb.IncreaseScore();
            Destroy(gameObject);
        }

        gameObject.transform.Translate(movementDir * Time.deltaTime * speed);
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.CompareTag("Player"))
        {
            health -= 1;
        }
        else if (coll.CompareTag("PlayerHitbox"))
        {
            // gameover...
            Destroy(gameObject);
        }
    }

}
