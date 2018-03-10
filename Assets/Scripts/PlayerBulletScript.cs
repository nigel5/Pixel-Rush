using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletScript : MonoBehaviour {

    public int damage;
    public int speed;

	// Update is called once per frame
	void Update () {
        transform.Translate(Vector2.up * Time.deltaTime * speed);
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        // Ignore all collision with "PlayerHitbox" since this is where the bullet get instantiated.
        if (coll.CompareTag("PlayerHitbox"))
        {
            return;
        }
        else if (coll.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
        else
        {
            // Probably collided with the enemy spawner, which is off the screen.
            Destroy(gameObject);
        }
    }
}
