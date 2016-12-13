using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowItemName : MonoBehaviour {

	RaycastHit hit;
	public GameObject ourObject;

	void Update()
	{
		if(Input.GetAxis("Fire1")!=0)
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if(Physics.Raycast(ray, out hit,2f))
			{
				ourObject = hit.collider.gameObject;
				Debug.Log ("object that was hit: "+ourObject);
			}
		}
	}
}
