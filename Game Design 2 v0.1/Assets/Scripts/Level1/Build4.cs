using UnityEngine;
using System.Collections;

public class Build4 : MonoBehaviour {

	public GameObject bottomBothBarRLarm;
	public GameObject armm;

	AudioSource audio;
	AudioSource audio2;

	public AudioClip error;
	public AudioClip inside;
	// Use this for initialization
	void Start () {
		
		audio = GetComponent<AudioSource> ();
		audio2 = GetComponent<AudioSource> ();

	}

	void Update(){
	}
	// Update is called once per frame

	public void OnTriggerEnter2D(Collider2D other){
		
			if (other.gameObject.name == "arm2") {
				audio.PlayOneShot (inside, 0.6f);
				armm.SetActive (false);
				bottomBothBarRLarm.SetActive (true);


		}
		else if (other.gameObject.name != "arm2" || other.gameObject.name != "arm") {
			audio2.PlayOneShot (error, 0.4f);
		}
	}
}

