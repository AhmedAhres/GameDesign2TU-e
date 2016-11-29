using UnityEngine;
using System.Collections;

public class Build3 : MonoBehaviour {

	public GameObject bottomBothBarRight;
	public GameObject itself;
	public GameObject bottomBothBarLeft;
	public GameObject bottomBothBarRL;
	public GameObject barRight;
	public GameObject barLeft;
	bool rightIn = false;
	bool leftIn = false;
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

	public void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.name == "bar-right") 
		{
			if (barLeft == false) {
				audio.PlayOneShot (inside, 0.5f);
				barRight.SetActive (false);
				bottomBothBarRight.SetActive (true);
				rightIn = true;
			} else {
				audio.PlayOneShot (inside, 0.5f);
				barRight.SetActive (false);
				bottomBothBarRL.SetActive (true);
			}
			itself.SetActive (false);
		} 
		if (other.gameObject.name == "bar-left") 
		{
			if (barRight == false) {
				audio.PlayOneShot (inside, 0.5f);
				barLeft.SetActive (false);
				bottomBothBarLeft.SetActive (true);
				leftIn = true;
			} else {
				audio.PlayOneShot (inside, 0.5f);
				barRight.SetActive (false);
				bottomBothBarRL.SetActive (true);
			}
			itself.SetActive (false);
		} 
	}
}
