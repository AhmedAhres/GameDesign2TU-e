using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class InputManager : MonoBehaviour
{
	public bool draggingItem = false;
	private GameObject draggedObject;
	private Vector2 touchOffset;
	public GameObject electronicsCan;
	public GameObject oneCheck;
	public GameObject oneCross;
	GameObject twoCheck;
	GameObject twoCross;
	public GameObject threeCheck;
	public GameObject threeCross;
	public GameObject fourCheck;
	public GameObject fourCross;
	public GameObject fiveCheck;
	public GameObject fiveCross;
	public GameObject sixCheck;
	public GameObject sixCross;
	Scene scene;
	float lev1Time;
	float lev2Time;
	float elecTime;
	float lev3Time;

	void Start()
	{
		twoCheck = GameObject.Find("2Check");
		twoCross = GameObject.Find("2Cross");
		scene = SceneManager.GetActiveScene();
	}

	void Update()
	{
		if (HasInput)
		{
			DragOrPickUp();
		} 
		else
		{
			CheckFinished();
			if (draggingItem)
				DropItem();
		}
	}

	Vector2 CurrentTouchPosition
	{
		get
		{ 
			return Camera.main.ScreenToWorldPoint(Input.mousePosition);
		}
	}
	private void DragOrPickUp()
	{
		var inputPosition = CurrentTouchPosition;
		if (draggingItem)
		{
			draggedObject.transform.position = inputPosition + touchOffset;
		}
		else
		{
			RaycastHit2D[] touches = Physics2D.RaycastAll(inputPosition, inputPosition, 0.5f);
			if (touches.Length > 0)
			{
				var hit = touches[0];
				if (hit.transform != null && hit.transform.tag == "Tile")
				{
					draggingItem = true;
					draggedObject = hit.transform.gameObject;
					touchOffset = (Vector2)hit.transform.position - inputPosition;
					hit.transform.GetComponent<Tile>().PickUp();
				}
			}
		}
	}

	private void CheckFinished()
	{
		foreach (GameObject gameObject in GameObject.FindGameObjectsWithTag("Tile")) {
			if (gameObject.transform.parent == null) {
				return;
			}
		}
		if (scene.name == "Level1") {
			StartCoroutine (lev1 ());
			lev1Time = Time.timeSinceLevelLoad;
			/*if (lev1Time <= 25f) {
				oneCheck.gameObject.SetActive (true);
			} else {
				oneCross.gameObject.SetActive (true);
			}*/
		}
		if (scene.name == "Level2") {
			StartCoroutine (lev2 ());
			lev2Time = Time.timeSinceLevelLoad;
			/*if (lev2Time <= 60)
				twoCheck.gameObject.SetActive (true);
			else {
				twoCross.gameObject.SetActive (true);
			}*/
		}
		if (scene.name == "Level3") {
			StartCoroutine (lev3());
			lev3Time = Time.timeSinceLevelLoad;
			/*if (lev3Time <= 60)
				threeCheck.gameObject.SetActive (true);
			else {
				threeCross.gameObject.SetActive (true);
			}*/
		}
	}
	

	IEnumerator lev1(){
		yield return new WaitForSeconds (0.7f);
		SceneManager.LoadScene ("Level1Mini");
	}
	IEnumerator lev2(){
		yield return new WaitForSeconds (0.7f);
		electronicsCan.gameObject.SetActive (true);
	}
	IEnumerator lev3(){
		yield return new WaitForSeconds (0.7f);
		SceneManager.LoadScene ("Level3Mini");
	}
		

	private bool HasInput
	{
		get
		{
			// returns true if either the mouse button is down or at least one touch is felt on the screen
			return Input.GetMouseButton(0);
		}
	}

	void DropItem()
	{
		draggingItem = false;
		draggedObject.GetComponent<Tile>().Drop();
	}
}