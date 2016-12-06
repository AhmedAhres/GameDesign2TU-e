using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	public GameObject snowman1;
	public GameObject snowman2;
	public GameObject snowman3;
	public GameObject snowman4;
	public GameObject arm1;
	public GameObject arm2;
	public GameObject arm3;
	public GameObject arm4;
	public GameObject sphere;
	public Vector2 aPosition1 = new Vector2(3,3);
	public Vector2 aPosition2 = new Vector2(3,3);
	public Vector2 aPosition3 = new Vector2(3,3);
	float s = 1;
	int pressed = 0;
	public Transform target;
	public float speed;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		Quaternion rot = transform.rotation;

		if (pressed == 0 && Input.GetKeyDown ("space")) {
			StartCoroutine (Snowman1 ());
			arm1.gameObject.SetActive (false);
			arm2.gameObject.SetActive (true);
		}
		if (pressed == 1 && Input.GetKeyDown ("space")) {
			StartCoroutine (Snowman2 ());
			arm1.gameObject.SetActive (false);
			arm3.gameObject.SetActive (true);
		}
		if (pressed == 2 && Input.GetKeyDown ("space")) {
			StartCoroutine (Snowman3 ());
			arm1.gameObject.SetActive (false);
			arm4.gameObject.SetActive (true);
		}
	}

		
	IEnumerator Snowman1 () {
		yield return new WaitForSeconds (0.05f);
		sphere.transform.position = Vector2.Lerp(new Vector2(transform.position.x, transform.position.y), aPosition1, 10);
		snowman1.SetActive (false);
		snowman2.SetActive (true);
		pressed = 1;
		yield return new WaitForSeconds (0.5f);
		arm2.gameObject.SetActive (false);
		arm1.gameObject.SetActive (true);
		//rot = Quaternion.Euler (0, 0, 0);
		//transform.rotation = rot;
	}
	IEnumerator Snowman2 () {
		yield return new WaitForSeconds (0.05f);
		sphere.transform.position = Vector2.Lerp(new Vector2(transform.position.x, transform.position.y), aPosition2, 10);
		snowman2.SetActive (false);
		snowman3.SetActive (true);
		pressed = 2;
		yield return new WaitForSeconds (0.5f);
		arm3.gameObject.SetActive (false);
		arm1.gameObject.SetActive (true);
	}
	IEnumerator Snowman3 () {
		yield return new WaitForSeconds (0.05f);
		sphere.transform.position = Vector2.Lerp(new Vector2(transform.position.x, transform.position.y), aPosition3, 10);
		snowman3.SetActive (false);
		snowman4.SetActive (true);
		pressed = 3;
		yield return new WaitForSeconds (0.5f);
		arm4.gameObject.SetActive (false);
		arm1.gameObject.SetActive (true);
	}
}
