using UnityEngine;
using System.Collections;

public class MoveSample2 : MonoBehaviour
{	
	void Start(){
		iTween.MoveTo(gameObject, iTween.Hash("x", 5.0f, "y", -0.9f, "time", 0.5));
	}
}

