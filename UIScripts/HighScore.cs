using UnityEngine;
using System.Collections;

public class HighScore : MonoBehaviour {

	TextMesh scoreDisplay;
	float highScore;
	// Use this for initialization
	void Start () {
		highScore = PlayerPrefs.GetFloat ("LastScore");
		scoreDisplay = this.gameObject.GetComponent<TextMesh> ();
	}
	
	// Update is called once per frame
	void Update () {
		scoreDisplay.text = highScore.ToString ();
	}
}
