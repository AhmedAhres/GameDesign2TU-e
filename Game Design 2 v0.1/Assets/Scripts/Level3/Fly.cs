﻿using UnityEngine;
using System.Collections;

public class Fly : MonoBehaviour {

	public Transform canv;
	public GameObject rocket;
	float y;
	float ratio;
	// Use this for initialization
	void Start () {
		ratio = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		ratio += 0.01f;
		if (Input.GetKey ("space") && canv.gameObject.activeInHierarchy == false) {
			transform.localPosition += new Vector3 (0f, 0.05f*ratio, 0f);
		}
	}
}
