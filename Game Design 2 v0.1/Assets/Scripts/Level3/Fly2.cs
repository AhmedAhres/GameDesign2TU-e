using UnityEngine;
using System.Collections;

public class Fly2 : MonoBehaviour {

	public GameObject rocket;
	public Transform canv;
	public GameObject rocket1;
	float y;
	float ratio;
	// Use this for initialization
	void Start () {
		ratio = 2f;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.localPosition.y <= 2)
			ratio = 0f;
		if (rocket1.transform.localPosition.y > 13)
			transform.localPosition += new Vector3 (0f, -0.05f*ratio, 0f);
	}
}
