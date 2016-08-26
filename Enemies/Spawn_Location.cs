using UnityEngine;
using System.Collections;

public class Spawn_Location : MonoBehaviour {

    public GameObject enemy;
    GameObject player;
    float timer;
	float spawnDelay;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
		spawnDelay = Random.Range (4, 8);
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 direction = player.transform.position - this.transform.position;
        timer += Time.deltaTime;
		if(timer >= spawnDelay)
        {
            GameObject enemyClone = Instantiate(enemy, this.transform.position, Quaternion.LookRotation(direction)) as GameObject;
            timer = 0;
			spawnDelay = Random.Range (1, 4);
        }
	}
}
