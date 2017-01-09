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
	float lev1Time;
	float lev2Time;
	float lev3Time;
	float elecTime;

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
			elecTime = Time.timeSinceLevelLoad;
			if (elecTime <= 60f) {
				fourCheck.gameObject.SetActive (true);
			} else fourCross.gameObject.SetActive (true);

		}
		if (scene.name == "Circuit") {
			threeCross.gameObject.SetActive (true);
		}



		if (scene.name == "Level1") {
			
			lev1Time = Time.timeSinceLevelLoad;
			if (lev1Time <= 25f) {
				oneCheck.gameObject.SetActive (true);
			} else {
				oneCross.gameObject.SetActive (true);
			}
		}
		if (scene.name == "Level2") {
			
			lev2Time = Time.timeSinceLevelLoad;
			if (lev2Time <= 60)
				twoCheck.gameObject.SetActive (true);
			else {
				twoCross.gameObject.SetActive (true);
			}
		}
		if (scene.name == "Level3") {
			
			lev3Time = Time.timeSinceLevelLoad;
			if (lev3Time <= 60)
				fiveCheck.gameObject.SetActive (true);
			else {
				fiveCross.gameObject.SetActive (true);
			}
		}

	}
}
