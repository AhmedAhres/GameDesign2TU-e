using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CanvasShoot : MonoBehaviour {

	public Transform canvas1;
	//private GameObject[] tileObjects;
	// Use this for initialization
	void Start () {
		StartCoroutine(Canvas());
	}
	
	// Update is called once per frame
	IEnumerator Canvas () {
		canvas1.gameObject.SetActive (true);
		yield return new WaitForSeconds (2);
		canvas1.gameObject.SetActive (false);

	}
}
