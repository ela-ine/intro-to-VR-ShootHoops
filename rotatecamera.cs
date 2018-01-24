using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatecamera : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//Transform t = GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		//transform.rotation = transform.rotation * Quaternion.Euler (0, 1, 0);
		float mouseX = Input.GetAxis ("Mouse X");
		transform.rotation = transform.rotation * Quaternion.Euler (0, mouseX, 0);
		Camera camera = GetComponentInChildren<Camera> ();
		float mouseY = Input.GetAxis ("Mouse Y");
		camera.transform.rotation = camera.transform.rotation * Quaternion.Euler (-mouseY, 0, 0);

	}
}
