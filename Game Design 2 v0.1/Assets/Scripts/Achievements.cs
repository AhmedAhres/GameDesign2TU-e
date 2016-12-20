using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

class Achievements : MonoBehaviour {

	Scene scene;

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
	}
}
