using UnityEngine;
using System.Collections;

public class Build4 : MonoBehaviour {

	public GameObject bottomBothBarRLarm;
	public GameObject armm;
	public GameObject before;

	AudioSource audio;
	//AudioSource audio2;
	//public AudioClip error;
	public AudioClip inside;
	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource> ();
		//audio2 = GetComponent<AudioSource> ();

	}

	void Update(){
	}
	// Update is called once per frame

	public void OnTriggerEnter2D(Collider2D other){
		
			if (other.gameObject.name == "arm2") {
				audio.PlayOneShot (inside, 0.5f);
				armm.SetActive (false);
				bottomBothBarRLarm.SetActive (true);
			

		}
	}
}

