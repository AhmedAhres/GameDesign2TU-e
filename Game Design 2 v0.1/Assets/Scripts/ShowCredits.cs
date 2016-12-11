using UnityEngine;
using System.Collections;

public class ShowCredits : MonoBehaviour {

	public GameObject mainCamera;

	// Use this for initialization
	 public void showCredits () {
		transform.Translate(-500, 0, Time.deltaTime);
	}
	
	public void backToMenu(){
		transform.Translate(500, 0, Time.deltaTime);
	}
}
