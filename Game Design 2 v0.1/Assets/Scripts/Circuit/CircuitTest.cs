using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircuitTest : MonoBehaviour {
	public GameObject[] connectorArray;
	public GameObject[] cableArray;
	public GameObject lastClicked;
	public GameObject currentlyClicked;
	public string possibleName;
	public string anotherName;
	// Use this for initialization
	void Start () {
		
	}
	
	void Update()
	{
		if( Input.GetMouseButtonDown(0) )
		{
			Ray ray = Camera.main.ScreenPointToRay( Input.mousePosition );
			RaycastHit hit;

			if( Physics.Raycast( ray, out hit, 100 ) )
			{
				Debug.Log( hit.transform.gameObject.name );
				currentlyClicked = hit.transform.gameObject;


				for (int i = 0; i < cableArray.Length; i++) {
					if (cableArray [i] == currentlyClicked) {
						cableArray [i].SetActive (false);
						lastClicked = null;
						currentlyClicked = null;
						possibleName = null;
						anotherName = null;
						break;
					}
				}



				if (currentlyClicked.name == "Background" || currentlyClicked == lastClicked || currentlyClicked.name == "Help") {
					currentlyClicked = null;

				
				} else if (lastClicked == null) {
					lastClicked = currentlyClicked;
					currentlyClicked = null;
				} else if (lastClicked != currentlyClicked) {
					possibleName = lastClicked.name + currentlyClicked.name;
					anotherName = currentlyClicked.name + lastClicked.name;
					int refNumber;
					for (int i = 0; i < cableArray.Length; i++) {
						if (cableArray [i].name == possibleName || cableArray [i].name == anotherName) {
							cableArray [i].SetActive (true);
							lastClicked = null;
							currentlyClicked = null;
							possibleName = null;
							anotherName = null;
							break;
						}
					}
				}
			}
		}
		if (Input.GetMouseButtonDown (1)) {
			currentlyClicked = null;
			lastClicked = null;
		}
	}

}
