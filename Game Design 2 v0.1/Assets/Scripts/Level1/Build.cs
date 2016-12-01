using UnityEngine;
using System.Collections;

public class Build : MonoBehaviour {

	public GameObject wheel; //just wheel
	public GameObject itself;
	public GameObject bottom; //just bottom
	public GameObject bottomWheelBoth;
	public GameObject bottomBothBar;
	public GameObject bar1;
	AudioSource audio;
	AudioSource audio2;
	public AudioClip inside; //audio clip for when an object is placed correctly
	public AudioClip error;

	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource> ();
		audio2 = GetComponent<AudioSource> ();
	}

	public void OnTriggerEnter2D(Collider2D other){

		if (other.gameObject.tag == "wheel") 
		{
			audio.PlayOneShot (inside, 0.5f);
			wheel.SetActive (false);
			bottomWheelBoth.SetActive (true);
			bottomWheelBoth.GetComponent<BoxCollider2D>().enabled = true;
			itself.GetComponent<BoxCollider2D>().enabled = false;
			wheel.GetComponent<CircleCollider2D>().enabled = false;
		}
		if (other.gameObject.tag != null && other.gameObject.tag != "wheel") {
			audio2.PlayOneShot (error, 0.7f);
		}

	}
}
