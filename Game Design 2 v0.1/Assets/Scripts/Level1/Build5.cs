using UnityEngine;
using System.Collections;

public class Build5 : MonoBehaviour {

	public GameObject withCW;
	public GameObject withSack;
	public GameObject withBoth;
	public GameObject target;
	public GameObject sack;
	public Transform canvas;
	public Transform canvas2;
	public GameObject cw;
	bool cwIn;
	bool sackIn;
	AudioSource audio;
	//AudioSource audio2;
	//public AudioClip error;
	public AudioClip inside;
	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource> ();
		//audio2 = GetComponent<AudioSource> ();
		target.SetActive (false);
	}

	void Update(){
		if (withBoth.gameObject.activeInHierarchy == true) {
			target.SetActive (true);
		}
	}
	// Update is called once per frame

	public void OnTriggerEnter2D(Collider2D other){

		if (other.gameObject.name == "sack2") 
		{
			if (withCW.gameObject.activeInHierarchy == false) {
				audio.PlayOneShot (inside, 0.6f);
				sack.SetActive (false);
				withSack.SetActive (true);
			} if (withCW.gameObject.activeInHierarchy == true) {
				audio.PlayOneShot (inside, 0.6f);
				sack.SetActive (false);
				withBoth.SetActive (true);
				canvas.gameObject.SetActive (false);
				StartCoroutine(Canvas());
			}
		} 
		if (other.gameObject == cw) 
		{
			if (withSack.gameObject.activeInHierarchy == false) {
				audio.PlayOneShot (inside, 0.6f);
				cw.SetActive (false);
				withCW.SetActive (true);
			}
			if(withSack.gameObject.activeInHierarchy == true) {
				audio.PlayOneShot (inside, 0.6f);
				cw.SetActive (false);
				withBoth.SetActive (true);
				canvas.gameObject.SetActive (false);
				StartCoroutine(Canvas());
			}
		} 
	}
	IEnumerator Canvas(){
		canvas2.gameObject.SetActive (true);
		yield return new WaitForSeconds (2);
		canvas2.gameObject.SetActive (false);
	}

}

