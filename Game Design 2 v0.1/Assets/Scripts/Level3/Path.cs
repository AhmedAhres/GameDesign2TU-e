using System.Collections;
using UnityEngine;

public class Path : MonoBehaviour {

	// Use this for initialization
	void Move () {
		iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath("RobotPath"), "time", 5, "easetype", iTween.EaseType.easeInOutCubic));
	}

}
