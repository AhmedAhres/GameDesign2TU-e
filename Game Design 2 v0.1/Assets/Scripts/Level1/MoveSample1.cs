using UnityEngine;
using System.Collections;

public class MoveSample1 : MonoBehaviour
{	
	void Start(){
		iTween.MoveTo(gameObject, iTween.Hash("x", 5.2f, "y", 0.7f, "time", 0.5));
	}
}

