using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class KillScreen : MonoBehaviour {

	RawImage img;

	public GameObject KillPartile;
	public Transform ParticleSpawn;
	public Vector3 SpawnOffset;

	public float DeathDelay;
	float deathTime;

	public static KillScreen MainKillScreen;

	// Use this for initialization
	void Start () {
		MainKillScreen = this;
		img = GetComponent<RawImage> ();
	}
	
	// Update is called once per frame
	void Update () {
		deathTime += Time.deltaTime;
		if(deathTime < DeathDelay)
			img.color = new Vector4 (img.color.r, img.color.g, img.color.b, 1.0f - (deathTime / DeathDelay));
		else
			img.color = new Vector4 (img.color.r, img.color.g, img.color.b, 0);
	}

	public void Kill()
	{
		deathTime = 0;
		/*if (KillPartile) {
			GameObject g = Instantiate (KillPartile, ParticleSpawn.position + SpawnOffset, Quaternion.identity) as GameObject;
			g.transform.parent = this.transform;
			g.transform.localPosition = ParticleSpawn.position + SpawnOffset;
		}*/
	}
}
