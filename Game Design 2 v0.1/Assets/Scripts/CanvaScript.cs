﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class CanvaScript : MonoBehaviour
{

	public Transform canvas1;
	public Transform canvas2;
	private GameObject[] tileObjects;
	private GameObject[] wrongObjects;
	// Use this for initialization
	void Start()
	{
		tileObjects = GameObject.FindGameObjectsWithTag("Tile");
		wrongObjects = GameObject.FindGameObjectsWithTag ("wrong");
		foreach (GameObject tileObject in tileObjects) {
			foreach (Collider2D collider in tileObject.GetComponents<Collider2D>())
				collider.enabled = false;
		}
		foreach (GameObject wrongObject in wrongObjects) {
			foreach (Collider2D collider in wrongObject.GetComponents<Collider2D>())
				collider.enabled = false;
		}
		StartCoroutine(Canvas());
	}
	
	// Update is called once per frame
	IEnumerator Canvas()
	{
		yield return new WaitForSeconds(1);
		canvas1.gameObject.SetActive(false);
		canvas2.gameObject.SetActive(true);
		yield return new WaitForSeconds(1);
		canvas2.gameObject.SetActive(false);
		foreach (GameObject tileObject in tileObjects) {
			foreach (Collider2D collider in tileObject.GetComponents<Collider2D>())
				collider.enabled = true;
		}
		foreach (GameObject wrongObject in wrongObjects) {
			foreach (Collider2D collider in wrongObject.GetComponents<Collider2D>())
				collider.enabled = true;
		}
	}
}
