using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	public GameObject snowman1;
	public GameObject snowman2;
	public GameObject sphere;
	int pressed = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Quaternion rot = transform.rotation;

		if (Input.GetKeyDown ("space")) {
			if (pressed == 0) {
				rot = Quaternion.Euler (0, 0, -28);
				transform.rotation = rot;
				//sphere.transform.localPosition.x += new Vector3 (0.1f, 0, 0);
				StartCoroutine (Snowman ());
				pressed = 1;
			}
		}

			
		
	}
	IEnumerator Snowman () {
		yield return new WaitForSeconds (2);
		snowman1.SetActive (false);
		snowman2.SetActive (true);
	}
}
