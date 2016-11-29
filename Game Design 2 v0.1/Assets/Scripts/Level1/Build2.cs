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
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.name == "Bar1") //&& build.bottomWheelDone == true 
		{
			itself.SetActive (false);
			audio.PlayOneShot (inside, 0.7f);
			bar1.SetActive (false);
			bottomBothBar.SetActive (true);
		} 
		if (other.gameObject.tag != null && other.gameObject.name != "Bar1") {
			audio2.PlayOneShot (error, 0.7f);
		}
	}
}
