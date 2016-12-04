using UnityEngine;
using System.Collections;

public class Build2 : MonoBehaviour {

	public GameObject bottomBothBar;
	public GameObject itself;
	public GameObject bar1;
	AudioSource audio;
	AudioSource audio2;
	public AudioClip error;
	public AudioClip inside;
	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource> ();
		audio2 = GetComponent<AudioSource> ();
	}


	public void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.name == "Bar1") //&& build.bottomWheelDone == true 
		{
			audio.PlayOneShot (inside, 0.6f);
			bar1.SetActive (false);
			bottomBothBar.SetActive (true);
			itself.GetComponent<BoxCollider2D>().enabled = false;
		} 
		if (other.gameObject.tag != null && other.gameObject.name != "Bar1") {
			audio2.PlayOneShot (error, 0.4f);
		}
	}
}
