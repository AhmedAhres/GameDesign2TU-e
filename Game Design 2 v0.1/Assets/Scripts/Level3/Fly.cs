using UnityEngine;
using System.Collections;

public class Fly : MonoBehaviour {

	public Transform canv;
	public GameObject rocket;
	private Component[] engines;
	private Vector3 startPosition;
	AudioSource launch;
	public AudioClip launcher;
	bool playAudio = false;
	float y;
	float ratio;
	// Use this for initialization
	void Start () {
		ratio = 0f;
		engines = GetComponentsInChildren<ParticleSystem>();
		startPosition = transform.localPosition;
		launch = GetComponent<AudioSource> ();
	}

	void playMusic(){
		launch.PlayOneShot (launcher, 0.7f);
	}
	
	// Update is called once per frame
	void Update () {

		if (!playAudio) {
			if (Input.GetKey ("space") && canv.gameObject.activeInHierarchy == false) {
				launch.PlayOneShot (launcher, 0.7f);
				ratio += 0.01f;
				playAudio = true;
			}
		}
		if (playAudio) {
			if (Input.GetKey ("space") && canv.gameObject.activeInHierarchy == false) {
				ratio += 0.01f;
			}
		} else if (transform.localPosition.y >= startPosition.y && transform.localPosition.y <= 13)
			ratio = Mathf.Max (ratio - 0.005f, -1.0f);
		else 
			ratio = 0.0f;
		
		transform.localPosition += new Vector3 (0f, 0.05f*ratio, 0f);
		foreach (ParticleSystem engine in engines) {
			var ps = engine.main;
			ps.startSize = Mathf.Min(ratio, 1.0f);
			ps.startLifetime = Mathf.Min(ratio*0.5f, 0.3f);
		}
	}
}
