﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircuitLVLA : MonoBehaviour {

	public GameObject[] playCables;
	public bool[] check;
	public GameObject goodJob;
	public bool[] reference1;
	public bool[] reference2;

	void Start(){
		check = new bool[playCables.Length];
	}
	// Update is called once per frame
	void Update () {
		checkValues1 ();
		for (int i = 0; i < playCables.Length; i++) {
			if (playCables [i].activeSelf) {
				check [i] = true;
			} else {
				check [i] = false;
			}
		}
		checkValues1 ();
		checkValues2 ();
	}
	void checkValues1(){
		for (int i = 0; i < check.Length; i++) {
			if (check [i] != reference1 [i]) {
				return;
		}

	}
		done ();
	}

	void checkValues2(){
		for (int i = 0; i < check.Length; i++) {
			if (check [i] != reference2 [i]) {
				return;
			} 
		}
		done ();
	}
	void done(){
		goodJob.SetActive (true);
	}
}
