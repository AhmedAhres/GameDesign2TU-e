using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour {

	public GameObject readyCan;
	public GameObject buildCan;
	public Transform canvas;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape) && readyCan.activeInHierarchy == false && buildCan.activeInHierarchy == false)
		{
			Paused ();

		}
	}

	public void Paused(){
		if (canvas.gameObject.activeInHierarchy == false) {
			canvas.gameObject.SetActive (true);
			Time.timeScale = 0;

		} 
		else 
		{
			canvas.gameObject.SetActive(false);

			Time.timeScale = 1;

		}
	}

	public void Restart(){
		
		Time.timeScale = 1;
		StartCoroutine (rest ());
	}

	public void Quit(){
		Time.timeScale = 1;
		StartCoroutine (leave ());
	}

	IEnumerator rest(){
		yield return new WaitForSeconds (0.7f);
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

	IEnumerator leave(){
		yield return new WaitForSeconds (0.7f);
		SceneManager.LoadScene ("Menu");
	}



}
