using UnityEngine;
using System.Collections;

public class Fly : MonoBehaviour
{

	public Transform canv;
	public GameObject rocket;
	private Component[] engines;
	private Vector3 startPosition;
	AudioSource launch;
	public AudioClip launcher;
	bool playAudio = false;
	float y;
	float ratio;
	public bool achievement;
	private bool robotAnimation, active;
	private GameObject robot;
	// Use this for initialization
	void Start()
	{
		ratio = 0f;
		engines = GetComponentsInChildren<ParticleSystem>();
		startPosition = transform.localPosition;
		launch = GetComponent<AudioSource>();
		robot = GameObject.FindGameObjectWithTag("Robot");
		robot.SetActive(false);
	}

	void playMusic()
	{
		launch.PlayOneShot(launcher, 0.7f);
	}
	
	// Update is called once per frame
	void Update()
	{
		if (!robotAnimation || !achievement) {
			if (transform.localPosition.y > startPosition.y) {
				if (Input.GetKey("space") && canv.gameObject.activeInHierarchy == false) {
					if (playAudio) {
						ratio += 0.01f;
					} else {
						launch.PlayOneShot(launcher, 0.7f);
						playAudio = true;
						ratio += 0.01f;
					}
				} else if (transform.localPosition.y <= 13) {
					ratio = Mathf.Max(ratio - 0.005f, -1.0f);
				}
			} else {
				if (ratio < -0.7f) {
					robotAnimation = true;
				}
				if (ratio < 0.0f) {
					ratio = 0.0f;
				}
				if (Input.GetKey("space") && canv.gameObject.activeInHierarchy == false) {
					if (playAudio) {
						ratio += 0.01f;
					} else {
						launch.PlayOneShot(launcher, 0.7f);
						playAudio = true;
						ratio += 0.01f;
					}
				}
			}
		} else {
			if (!active)
			StartCoroutine(RobotActivate());
			active = true;
		}
		
		if (ratio <= 0) {
			launch.Stop();
			playAudio = false;
		}

		transform.localPosition += new Vector3(0f, 0.05f * ratio, 0f);
		foreach (ParticleSystem engine in engines) {
			var ps = engine.main;
			ps.startSize = Mathf.Min(ratio, 1.0f);
			ps.startLifetime = Mathf.Min(ratio * 0.5f, 0.3f);
		}
	}

	IEnumerator RobotActivate() {
		yield return new WaitForSeconds(1);
		robot.SetActive(true);
		robot.SendMessage("Move");
	}
}
