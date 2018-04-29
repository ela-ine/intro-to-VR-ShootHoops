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
		GameObject ballinst;

		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			ballinst = Instantiate (ballPrefab); 
			ballinst.transform.position = transform.position + new Vector3 (0, 3, 0);
			Rigidbody rb = ballinst.GetComponent<Rigidbody> (); 
			Camera camera = GetComponentInChildren<Camera> ();
			rb.velocity = camera.transform.rotation * Vector3.forward * 9.0f;
		}

	}
}