using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHint : MonoBehaviour {
	
	public GameObject lights;
	public GameObject hints;
	private bool hintsAreOn;
	// Use this for initialization
	void Start () {
		hintsAreOn = false;
	}
	
	// Update is called once per frame
	void OnMouseDown(){
		if (hintsAreOn) {
			lights.SetActive (true);
			hints.SetActive (false);
			hintsAreOn = false;
		} else {
			lights.SetActive (false);
			hints.SetActive (true);
			hintsAreOn = true;
		}
	}
}
