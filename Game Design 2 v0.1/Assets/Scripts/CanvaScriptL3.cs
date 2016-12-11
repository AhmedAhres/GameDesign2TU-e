using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CanvaScriptL3 : MonoBehaviour
{

	public Transform canvas1;

	// Use this for initialization
	void Start()
	{
		StartCoroutine(Canvas());
	}
	
	// Update is called once per frame
	IEnumerator Canvas()
	{
		yield return new WaitForSeconds(1.5f);
		canvas1.gameObject.SetActive(false);
	}
}
