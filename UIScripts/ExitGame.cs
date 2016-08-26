using UnityEngine;
using System.Collections;


public class ExitGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision other)
    {
        // If the player shoots the button load the scene
        if (other.transform.CompareTag("Bullet"))
        {
            Application.Quit();
        }
    }
}
