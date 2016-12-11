﻿using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	public GameObject snowman1;
	public GameObject snowman2;
	public GameObject snowman3;
	public GameObject snowman4;
	public GameObject tre0;
	public GameObject tre1;
	public GameObject tre2;
	public GameObject tre3;
	int pressed = 0;
	AudioSource src;
	public AudioClip snowHit;

	// Use this for initialization
	void Start () {
		src = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown ("space")) {
			if (pressed == 0) {
				tre0.SetActive (false);
				tre1.SetActive (true);
				StartCoroutine (Snowman1 ());
			}
			if (pressed == 1) {
				tre0.SetActive (false);
				tre2.SetActive (true);
				StartCoroutine (Snowman2 ());
			}
			if (pressed == 2) {
				tre0.SetActive (false);
				tre3.SetActive (true);
				StartCoroutine (Snowman3 ());
			}
		}

			

	}
	IEnumerator Snowman1 () {
		yield return new WaitForSeconds (0.2f);
		tre1.SetActive (false);
		tre0.SetActive (true);
		yield return new WaitForSeconds (0.2f);
		src.PlayOneShot (snowHit, 0.9f);
		snowman1.SetActive (false);
		snowman2.SetActive (true);
		pressed = 1;

	}
	IEnumerator Snowman2 () {
		yield return new WaitForSeconds (0.2f);
		tre2.SetActive (false);
		tre0.SetActive (true);
		yield return new WaitForSeconds (0.2f);
		src.PlayOneShot (snowHit, 0.9f);
		snowman2.SetActive (false);
		snowman3.SetActive (true);
		pressed = 2;
	}
	IEnumerator Snowman3 () {
		yield return new WaitForSeconds (0.2f);
		tre3.SetActive (false);
		tre0.SetActive (true);
		yield return new WaitForSeconds (0.2f);
		src.PlayOneShot (snowHit, 0.9f);
		snowman3.SetActive (false);
		snowman4.SetActive (true);
		pressed = 3;
	}
}
