using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other)
	{
        // If the player shoots the button load the scene
		if (other.CompareTag ("Bullet"))
		{
			
			SceneManager.LoadScene ("TestWorld");
		}
	}

}
