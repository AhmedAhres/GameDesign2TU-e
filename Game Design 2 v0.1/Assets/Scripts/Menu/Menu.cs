﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	public GameObject mainMenu;
	public GameObject credits;
	public GameObject achievements;
	// Use this for initialization
	void Start () 
	{
		/*
		// set the desired aspect ratio (the values in this example are
		// hard-coded for 16:9, but you could make them into public
		// variables instead so you can set them at design time)
		float targetaspect = 16.0f / 9.0f;

		// determine the game window's current aspect ratio
		float windowaspect = (float)Screen.width / (float)Screen.height;

		// current viewport height should be scaled by this amount
		float scaleheight = windowaspect / targetaspect;

		// obtain camera component so we can modify its viewport
		Camera camera = GetComponent<Camera>();

		// if scaled height is less than current height, add letterbox
		if (scaleheight < 1.0f)
		{  
			Rect rect = camera.rect;

			rect.width = 1.0f;
			rect.height = scaleheight;
			rect.x = 0;
			rect.y = (1.0f - scaleheight) / 2.0f;

			camera.rect = rect;
		}
		else // add pillarbox
		{
			float scalewidth = 1.0f / scaleheight;

			Rect rect = camera.rect;

			rect.width = scalewidth;
			rect.height = 1.0f;
			rect.x = (1.0f - scalewidth) / 2.0f;
			rect.y = 0;

			camera.rect = rect;
		}
		*/
	}

	public void showMainMenu(){
		mainMenu.SetActive(true);
		credits.SetActive(false);
		achievements.SetActive(false);
	}

	public void showCredits(){
		mainMenu.SetActive(false);
		credits.SetActive(true);
		achievements.SetActive(false);
	}

	public void showAchievements(){
		mainMenu.SetActive(false);
		credits.SetActive(false);
		achievements.SetActive(true);
	}

	public void goLevel1(){
		Invoke ("changeLevel", 0.2f);
	}

	void changeLevel(){
		SceneManager.LoadScene("Level1");
	}

	public void exitGame(){
		Invoke ("exit", 0.2f);
	}

	void exit(){
		Application.Quit ();
	}
}
