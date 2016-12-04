using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Tile : MonoBehaviour
{

	private Transform touchingTile;
	private AudioSource audSource;
	private Sprite startSprite;
	public Sprite highlightSprite;
	private SpriteRenderer renderer;
	public string tag;

	private void Awake()
	{
		audSource = gameObject.GetComponent<AudioSource>();
		renderer = GetComponent<SpriteRenderer>();
		startSprite = renderer.sprite;
	}

	private void OnMouseEnter()
	{
		if (!GameObject.FindWithTag("MainCamera").GetComponent<InputManager>().draggingItem) {
			renderer.sprite = highlightSprite;
		}
	}

	void OnMouseExit()
	{
		renderer.sprite = startSprite;
	}

	public void PickUp()
	{
		renderer.sprite = startSprite;
		transform.localScale = new Vector3(1.1f, 1.1f, 1.1f);
		gameObject.GetComponent<SpriteRenderer>().sortingOrder = 2;
	}

	public void Drop()
	{
		transform.localScale = new Vector3(1, 1, 1);
		gameObject.GetComponent<SpriteRenderer>().sortingOrder = 1;

		Vector2 newPosition;
		if (touchingTile == null) {
			return;
		}

		var parentCell = touchingTile;
		newPosition = parentCell.position;
		transform.parent = parentCell;
		StartCoroutine(SlotIntoPlace(transform.position, newPosition));
	}


	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == tag) {
			if (other.transform.childCount == 0) {
				touchingTile = other.transform;
			}
		}
	}

	void OnTriggerExit2D(Collider2D other)
	{
		if (other.gameObject.tag == tag) {
			touchingTile = null;
		}
	}

	IEnumerator SlotIntoPlace(Vector2 startingPos, Vector2 endingPos)
	{
		float duration = 0.1f;
		float elapsedTime = 0;
		audSource.Play();
		while (elapsedTime < duration) {
			transform.position = Vector2.Lerp(startingPos, endingPos, elapsedTime / duration);
			elapsedTime += Time.deltaTime;
			yield return new WaitForEndOfFrame();
		}
		transform.position = endingPos;
	}
}