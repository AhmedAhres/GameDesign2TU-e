using UnityEngine;
using System.Collections;

public class Build3 : MonoBehaviour {

	public GameObject bottomBothBarRight;
	public GameObject itself;
	public GameObject bottomBothBarLeft;
	public GameObject bottomBothBarRL;
	public GameObject barRight;
	public GameObject barLeft;
	public GameObject before;
	public GameObject bbefore;
	bool rightIn;
	bool leftIn;
	AudioSource audio;
	AudioSource audio2;
	public AudioClip error;
	public AudioClip inside;
	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource> ();
		audio2 = GetComponent<AudioSource> ();
		rightIn = false;
		leftIn = false;
	
	}

	void Update(){
		if(itself.gameObject.activeInHierarchy == true){
			//Destroy (before);
			//Destroy (bbefore);
		}
	}
	// Update is called once per frame

	public void OnTriggerEnter2D(Collider2D other){
		
		if (other.gameObject.name == "bar-right") 
		{
			if (leftIn == false) {
				audio.PlayOneShot (inside, 0.6f);
				barRight.SetActive (false);
				bottomBothBarRight.SetActive (true);
				rightIn = true;
			} else {
				audio.PlayOneShot (inside, 0.6f);
				barRight.SetActive (false);
				bottomBothBarRL.SetActive (true);
				itself.GetComponent<BoxCollider2D> ().enabled = false;
			}
		} 
		if (other.gameObject.name == "bar-left") 
		{
			if (bottomBothBarRight.gameObject.activeInHierarchy == false) {
				audio.PlayOneShot (inside, 0.6f);
				barLeft.SetActive (false);
				bottomBothBarLeft.SetActive (true);
				leftIn = true;
			}
			if(bottomBothBarRight.gameObject.activeInHierarchy == true) {
				audio.PlayOneShot (inside, 0.6f);
				barLeft.SetActive (false);
				bottomBothBarRL.SetActive (true);
				itself.GetComponent<BoxCollider2D> ().enabled = false;
			}
		} 
		//else if (other.gameObject != barRight && other.gameObject != barLeft) {
		//	audio2.PlayOneShot (error, 0.4f);
		//}
	}
}
