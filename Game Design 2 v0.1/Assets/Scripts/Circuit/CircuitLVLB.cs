﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircuitLVLB : MonoBehaviour {

	public GameObject[] playCables;
	public GameObject[] Leds;
	public bool[] check;
	public GameObject goodJob;
	public bool[] reference1;

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
	}
	void checkValues1(){
		for (int i = 0; i < check.Length; i++) {
			if (check [i] != reference1 [i]) {
				return;
			}

		}
		done ();
	}

	void done(){
		goodJob.SetActive (true);
		for (int i = 0; i < Leds.Length; i++) {
			Leds [i].SetActive (true);
		}
	}
}
