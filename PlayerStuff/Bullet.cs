using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
    [Tooltip("Bullets speed")]
    [SerializeField]
    float speed = 100;

    GameObject gunController;
	public string controller;
    Vector3 targetDirection;
    GameObject player;
	GameObject playerScore;

	public GameObject deathParticles;

    float timer;

    [Tooltip("The amount of score the player gains for killing an enemy")]
	public float scoreAmount;

	// Use this for initialization
	void Start () {
        // find the controller that will fire the bullet
		gunController = GameObject.FindWithTag (controller);

        targetDirection = gunController.transform.forward;
        player = GameObject.FindWithTag("Player");
			
		playerScore = GameObject.FindWithTag ("Score");
	}
	
	// Update is called once per frame
	void Update () {

        // move the bullet in the direction the controller was facing when spawned
        transform.position += targetDirection * speed * Time.deltaTime;

        // Kill bullet after 5 seconds
        timer += Time.deltaTime;
        if(timer > 5)
        {
            BulletLifeIsOver();
        }
	}

    void OnCollisionEnter(Collision col)
    {
        // Destroy the enemy and bullet if enemy is hit
        if(col.transform.CompareTag("Enemy"))
        {
			Instantiate (deathParticles, this.transform.position, Quaternion.identity);
			playerScore.GetComponent<Score> ().score += scoreAmount;
			Destroy(col.gameObject);
			Destroy(this.gameObject);

        }

    }

    void BulletLifeIsOver()
    {
		Instantiate (deathParticles, this.transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }


}
