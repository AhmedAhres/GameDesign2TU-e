using UnityEngine;
using System.Collections;

public class MoveSample : MonoBehaviour
{	
	void Start(){
		iTween.MoveTo(gameObject, iTween.Hash("x", 5.2f, "y", 1.4f, "time", 0.5));
	}
}

