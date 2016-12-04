using UnityEngine;
using System.Collections;

public class CanvasScript2 : MonoBehaviour {

	public Transform canvas1;
	public Transform canvas2;
	// Use this for initialization
	void Start () {
		
		StartCoroutine(Canvas());
	}


	// Update is called once per frame
	IEnumerator Canvas () {
		yield return new WaitForSeconds (1);
		canvas1.gameObject.SetActive (false);
		canvas2.gameObject.SetActive (true);
		yield return new WaitForSeconds (1);
		canvas2.gameObject.SetActive (false);

	}

}