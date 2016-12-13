using UnityEngine;
using System.Collections;

public class Fly2 : MonoBehaviour {

	public GameObject rocket;
	public Transform canv;
	float y;
	float ratio;
	// Use this for initialization
	void Start () {
		ratio = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		ratio += 0.01f;
		if (Input.GetKey ("space") && transform.localPosition.y>2 && canv.gameObject.activeInHierarchy == false) {
			transform.localPosition += new Vector3 (0f, -0.05f*ratio, 0f);
		}
	}
}
