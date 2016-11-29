using UnityEngine;
using System.Collections;

public class Build : MonoBehaviour {

	public GameObject wheel; //just wheel
	public GameObject bottom; //just bottom
	public GameObject bottomWheelBoth;
	public GameObject bottomBar;
	public GameObject bottomBothBar;
	bool bottomWheelDone = false;
	AudioSource audio;
	AudioSource audio2;
	public AudioClip inside; //audio clip for when an object is placed correctly
	public AudioClip error;

	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource> ();
		audio2 = GetComponent<AudioSource> ();
	}

	// Update is called once per frame
	void Update () {
		if (bottomWheelBoth.activeInHierarchy == true) {
			bottomWheelDone = true;
		}
	}

	public void OnTriggerEnter2D(Collider2D other){

		if (other.gameObject.tag == "wheel") 
		{
			audio.PlayOneShot (inside, 0.5f);
				wheel.SetActive (false);
				bottomWheelBoth.SetActive (true);
			
		}
		if (other.gameObject.name == "Bar1") {
			if (bottomWheelDone == true) {

			}
		} else {
			audio2.PlayOneShot (error);
		}

	}
}
