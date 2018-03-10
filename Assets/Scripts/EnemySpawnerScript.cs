using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour {

    public GameObject enemy;

    float spawningInterval = 1F;
    float xSpawnBounds;
    float ySpawnBounds;

	// Use this for initialization
	void Start () {
        Vector3 temp = Camera.main.ViewportToWorldPoint(new Vector3(1.0F, 1.0F, 1.0F));
        xSpawnBounds = temp.x;
        ySpawnBounds = temp.y;

        InvokeRepeating("SpawnEnemy", 0.2F, spawningInterval);
	}
	
    void SpawnEnemy()
    {
        Instantiate(enemy, new Vector3(Random.Range(-xSpawnBounds + 0.02F, xSpawnBounds - 0.02F), ySpawnBounds, 5.0F), Quaternion.identity);
    }

    public void IncreaseSpawningSpeed()
    {
        // Can't have negative spawning interval
        if (spawningInterval - 0.25F > 0)
        {
            spawningInterval -= 0.25F;
            CancelInvoke();
            InvokeRepeating("SpawnEnemy", 0, spawningInterval);
        }
        else
        {
            // Max spawning interval
            spawningInterval = 0.05F;
        }
    }
}
