using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpriteScript : MonoBehaviour {

	public int health;
	public int shield;
	public int speed;

	// 1: Straight down
	// 2: Diagonal
	// 3: Crazy
	public int movementType;
	Vector2 movementDir;

	public bool canShoot;
	public int damage;

	// Use this for initialization
	void Start () {
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
            Destroy(this);
        }

        gameObject.transform.Translate(movementDir * Time.deltaTime);
	}

    void OnCollisionEnter2D(Collision2D coll)
    {

    }

}
