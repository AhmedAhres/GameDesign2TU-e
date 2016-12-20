using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

class Achievements : MonoBehaviour {



	Scene scene;
	public GameObject oneCheck;
	public GameObject oneCross;
	public GameObject twoCheck;
	public GameObject twoCross;
	public GameObject threeCheck;
	public GameObject threeCross;
	public GameObject fourCheck;
	public GameObject fourCross;
	public GameObject fiveCheck;
	public GameObject fiveCross;
	public GameObject sixCheck;
	public GameObject sixCross;

	// Use this for initialization
	void Awake () {
		scene = SceneManager.GetActiveScene();
		DontDestroyOnLoad (this);
	}
	
	// Update is called once per frame
	void Update () {
		if (scene.name == "Achievements") {
			this.gameObject.SetActive (true);
		}

		if (scene.name == "Circuit2") {
			threeCheck.gameObject.SetActive (true);
		}
		if (scene.name == "Circuit") {
			threeCross.gameObject.SetActive (true);
		}

	}
}
