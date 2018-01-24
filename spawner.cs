using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour {
	public GameObject ballPrefab;

	// Use this for initialization
	void Start () {
		
	}

	Rigidbody createBall () {
		GameObject instance = Instantiate (ballPrefab);
		Rigidbody rb = instance.GetComponent<Rigidbody> ();
		return rb;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			Rigidbody rb = createBall();
			rb.velocity = Vector3.forward * 5.0f;
		}

		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			Rigidbody rb = createBall();
			rb.velocity = Vector3.left * 5.0f;
		}

		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			Rigidbody rb = createBall();
			rb.velocity = Vector3.back * 5.0f;
		}

		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			Rigidbody rb = createBall();
			rb.velocity = Vector3.right * 5.0f;
		}
	}
}
