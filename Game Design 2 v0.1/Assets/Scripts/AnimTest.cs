using UnityEngine;
using System.Collections;

public class AnimTest : MonoBehaviour {

	public GameObject gameobj;
	// Use this for initialization
	void Start () {
		iTween.MoveTo (gameobj, iTween.Hash("time",3,"delay",1));
	}
	
	// Update is called once per frame
	void Update () {
	}
}
