using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

    public float score;
    TextMesh scoreDisplay;

	// Use this for initialization
	void Start () {
        score = 0;
        scoreDisplay = this.gameObject.GetComponent<TextMesh>();
	}

    void Update()
    {
        scoreDisplay.text = score.ToString();
    }
	
}
