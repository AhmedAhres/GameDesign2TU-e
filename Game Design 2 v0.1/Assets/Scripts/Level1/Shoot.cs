using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	public GameObject snowman1;
	public GameObject snowman2;
	public GameObject snowman3;
	public GameObject snowman4;
	public GameObject tre0;
	public GameObject tre01;
	public GameObject tre02;
	public GameObject tre1;
	public GameObject tre2;
	public GameObject tre3;
	public GameObject sphere;
	public GameObject sphere01;
	public GameObject sphere02;
	public Transform can;
	public Transform canvas;
	int pressed = 0;
	AudioSource src;
	AudioSource src2;
	public AudioClip snowHit;
	public AudioClip throw1;
	//public float speed = 5.0;
	//public float turnSpeed = 1.5;
	//Vector3 target;

	// Use this for initialization
	void Start () {
		src = GetComponent<AudioSource> ();
		src2 = GetComponent<AudioSource> ();
		sphere01.SetActive (false);
		sphere02.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (can.gameObject.activeInHierarchy == false) {
			if (Input.GetKeyDown ("space")) {
				if (pressed == 0) {
					sphere.AddComponent<MoveSample> ();
					tre0.SetActive (false);
					tre1.SetActive (true);
					StartCoroutine (Snowman1 ());
				}
				if (pressed == 1) {
					sphere01.AddComponent<MoveSample1> ();
					tre01.SetActive (false);
					tre2.SetActive (true);
					StartCoroutine (Snowman2 ());
				}
				if (pressed == 2) {
					sphere02.AddComponent<MoveSample2> ();
					tre02.SetActive (false);
					tre3.SetActive (true);
					StartCoroutine (Snowman3 ());
				}
			}
		}
			

	}
	IEnumerator Snowman1 () {
		yield return new WaitForSeconds (0.2f);
		tre1.SetActive (false);
		tre01.SetActive (true);
		sphere01.SetActive (true);
		src2.PlayOneShot(throw1,0.4f);
		yield return new WaitForSeconds (0.2f);
		sphere.SetActive (false);
		src.PlayOneShot (snowHit, 1f);
		snowman1.SetActive (false);
		snowman2.SetActive (true);
		pressed = 1;

	}
	IEnumerator Snowman2 () {
		yield return new WaitForSeconds (0.2f);
		tre2.SetActive (false);
		tre02.SetActive (true);
		sphere02.SetActive (true);
		src2.PlayOneShot(throw1,0.4f);
		yield return new WaitForSeconds (0.2f);
		src.PlayOneShot (snowHit, 1f);
		sphere01.SetActive (false);
		snowman2.SetActive (false);
		snowman3.SetActive (true);
		pressed = 2;
	}
	IEnumerator Snowman3 () {
		yield return new WaitForSeconds (0.2f);
		tre3.SetActive (false);
		tre01.SetActive (true);
		src2.PlayOneShot(throw1,0.4f);
		yield return new WaitForSeconds (0.2f);
		sphere02.SetActive (false);
		src.PlayOneShot (snowHit, 1f);

		snowman3.SetActive (false);
		snowman4.SetActive (true);
		pressed = 3;
		yield return new WaitForSeconds (0.7f);
		canvas.gameObject.SetActive (true);
	}


}
