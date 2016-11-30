using UnityEngine;
using System.Collections;

public class Build : MonoBehaviour {

	public GameObject wheel; //just wheel
	public GameObject bottom; //just bottom
	public GameObject itself;
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

	// Update is called once per frame
	public void Update () {
		if (bottomWheelBoth.activeInHierarchy == true) {
		}
	}

	public void OnTriggerEnter2D(Collider2D other){

		if (other.gameObject.tag == "wheel") 
		{
			audio.PlayOneShot (inside, 0.7f);
			wheel.SetActive (false);
			bottomWheelBoth.SetActive (true);
			bottomWheelBoth.GetComponent<BoxCollider2D>().enabled = true;
		}
		if (other.gameObject.tag != null && other.gameObject.tag != "wheel") {
			audio2.PlayOneShot (error, 0.7f);
		}

	}
}
