using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class InputManager : MonoBehaviour
{
	public bool draggingItem = false;
	private GameObject draggedObject;
	private Vector2 touchOffset;
	Scene scene;

	void Start()
	{
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
		}
		if (scene.name == "Level2") {
			StartCoroutine (lev2 ());
		}
		if (scene.name == "Level3") {
			StartCoroutine (lev3());
		}
	}

	IEnumerator lev1(){
		yield return new WaitForSeconds (0.7f);
		SceneManager.LoadScene ("Level1Mini");
	}
	IEnumerator lev2(){
		yield return new WaitForSeconds (0.7f);
		SceneManager.LoadScene ("Circuit");
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