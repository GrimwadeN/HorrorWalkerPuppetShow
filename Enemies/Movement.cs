using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    [Header("Enemy variables")]
    [Tooltip("Enemies movement speed towards the player")]
    public float moveSpeed;

    GameObject player;

	// Use this for initialization
	void Start () {
        player = GameObject.FindWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 targetPosition = player.transform.position;
        Vector3 direction = targetPosition - transform.position;
        transform.position += direction * moveSpeed * Time.deltaTime;
      
	}
}
