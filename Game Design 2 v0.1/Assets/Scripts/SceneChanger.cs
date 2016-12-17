using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Lev3(){
		StartCoroutine (goToLev3 ());
	}

	public void Advan(){
		StartCoroutine (Advanced ());
	}
	public void Basi(){
		StartCoroutine (Basic ());
	}

	IEnumerator goToLev3(){
		yield return new WaitForSeconds (0.7f);
		SceneManager.LoadScene ("Level2");
	}
	IEnumerator Basic(){
		yield return new WaitForSeconds (0.7f);
		SceneManager.LoadScene ("Circuit");
	}
	IEnumerator Advanced(){
		yield return new WaitForSeconds (0.7f);
		SceneManager.LoadScene ("Circuit2");
	}
}

