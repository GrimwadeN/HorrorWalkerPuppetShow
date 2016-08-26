using UnityEngine;
using System.Collections;

public class ShootLeft : MonoBehaviour {

	SteamVR_TrackedController leftController;
	ClickedEventArgs e;

	[Header("Bullet Object")]
	[Tooltip("Place the object to be used as a bullet here")]
	public GameObject bullet;
	public string controller;

	AudioSource audio;

	GameObject gunController;

	// Use this for initialization
	void Start () {
		leftController = GetComponent<SteamVR_TrackedController>();
		leftController.TriggerClicked += LeftController_TriggerClicked;       
		gunController = GameObject.FindWithTag (controller);
		audio = GetComponent<AudioSource> ();
	}



	// Update is called once per frame
	void Update () {

	}

	private void LeftController_TriggerClicked(object sender, ClickedEventArgs e)
	{
		Vector3 offset = new Vector3 (gunController.transform.position.x, gunController.transform.position.y, gunController.transform.position.z + 2);
		Instantiate(bullet, transform.position, Quaternion.identity);
		audio.Play ();
	}
}
