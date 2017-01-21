using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHint : MonoBehaviour {

	public GameObject lights;
	public GameObject hints;
	private bool hintsAreOn;
	// Use this for initialization
	void Start () {
		lights.SetActive (false);
		hints.SetActive (true);
		hintsAreOn = true;
	}

	void initializeHints(){
		lights.SetActive (false);
		hints.SetActive (true);
		hintsAreOn = true;
	}

	void Update(){
		if (Input.GetMouseButtonDown(0)) {
			if (hintsAreOn) {
				lights.SetActive(true);
				hints.SetActive(false);
				hintsAreOn = false;
			}
		}
	}

	// Update is called once per frame
	void OnMouseDown(){
		if (!hintsAreOn) {
			Debug.Log("help");
			Invoke ("initializeHints", 0.1f);
		}
	}
}
