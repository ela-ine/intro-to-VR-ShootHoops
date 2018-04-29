using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatecamera : MonoBehaviour {
	public float mouseSpeed;
	// Use this for initialization
	void Start () {
		//Transform t = GetComponent<Transform> ();
		mouseSpeed = 3.0f;

	}
	
	// Update is called once per frame
	void Update () {
		//transform.rotation = transform.rotation * Quaternion.Euler (0, 1, 0);
		float mouseX = Input.GetAxis ("Mouse X");
		transform.rotation = transform.rotation * Quaternion.Euler (0, mouseX * mouseSpeed, 0);
		Camera camera = GetComponentInChildren<Camera> ();
		float mouseY = Input.GetAxis ("Mouse Y");
		camera.transform.localRotation = camera.transform.localRotation * Quaternion.Euler (-mouseY * mouseSpeed, 0, 0);

	}
}
