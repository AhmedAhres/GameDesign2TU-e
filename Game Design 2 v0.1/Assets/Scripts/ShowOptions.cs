using UnityEngine;
using System.Collections;

public class ShowOptions : MonoBehaviour {


	public void showOptions () {
		transform.Translate(0, -280, Time.deltaTime);
	}

	public void backToMenu(){
		transform.Translate(0, 280, Time.deltaTime);
	}
}
