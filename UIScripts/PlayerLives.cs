using UnityEngine;
using System.Collections;

public class PlayerLives : MonoBehaviour {

    TextMesh livesLeft;
    GameObject playerHealth;
	// Use this for initialization
	void Start () {
        livesLeft = this.gameObject.GetComponent<TextMesh>();
        playerHealth = GameObject.FindWithTag("PlayerHealth");
    }
	
	// Update is called once per frame
	void Update ()
    {
        livesLeft.text = playerHealth.GetComponent<PlayerHealth>().playerLives.ToString();
	}
}
