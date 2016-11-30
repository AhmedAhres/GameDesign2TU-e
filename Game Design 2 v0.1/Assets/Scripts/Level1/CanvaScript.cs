using UnityEngine;
using System.Collections;

public class CanvaScript : MonoBehaviour {

	public Transform canvas1;
	public Transform canvas2;
	public GameObject ob1;
	public GameObject ob2;
	public GameObject ob3;
	public GameObject ob4;
	public GameObject ob5;
	public GameObject ob8;
	// Use this for initialization
	void Start () {
		ob1.GetComponent<PolygonCollider2D>().enabled = false;
		ob2.GetComponent<BoxCollider2D>().enabled = false;
		ob3.GetComponent<CircleCollider2D>().enabled = false;
		ob4.GetComponent<BoxCollider2D>().enabled = false;
		ob5.GetComponent<PolygonCollider2D>().enabled = false;
		ob8.GetComponent<PolygonCollider2D>().enabled = false;
		StartCoroutine(Canvas());
	}
	
	// Update is called once per frame
	IEnumerator Canvas () {
		yield return new WaitForSeconds (1);
		canvas1.gameObject.SetActive (false);
		canvas2.gameObject.SetActive (true);
		yield return new WaitForSeconds (1);
		canvas2.gameObject.SetActive (false);
		ob1.GetComponent<PolygonCollider2D>().enabled = true;
		ob2.GetComponent<BoxCollider2D>().enabled = true;
		ob3.GetComponent<CircleCollider2D>().enabled = true;
		ob4.GetComponent<BoxCollider2D>().enabled = true;
		ob5.GetComponent<PolygonCollider2D>().enabled = true;
		ob8.GetComponent<PolygonCollider2D>().enabled = true;
	}
}
