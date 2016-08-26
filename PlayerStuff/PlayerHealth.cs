using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour {

    public float playerLives = 3;
	float hit;

	// Use this for initialization
	void Start () {

	}
    void Update()
    {
		if (playerLives <= 0.1f)
        {
            // When player dies load the menu screen
			PlayerPrefs.SetFloat("LastScore", GameObject.FindWithTag ("Score").GetComponent<Score>().score);
            SceneManager.LoadScene("MenuScene");
        }
    }
	
	void OnTriggerEnter(Collider other)
    {
        // Reduce health if enemy gets to player
        if(other.CompareTag("Enemy"))
        {
			playerLives -= 1;
            Destroy(other.gameObject);
			if(KillScreen.MainKillScreen)
				KillScreen.MainKillScreen.Kill ();
        }
    }
}
