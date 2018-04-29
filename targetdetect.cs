using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetdetect : MonoBehaviour {

	public GameObject targetPrefab;

	GameObject targetinst;

	void Start () {

	}

	// Update is called once per frame
	void Update () {
		}

	void OnCollisionEnter (Collision collision) {

		andscore score = FindObjectOfType<andscore> ();
		score.IncrementScore(1);

		targetinst = Instantiate (targetPrefab);
		targetinst.transform.position = transform.position + new Vector3 (Random.Range (-3.0f, 3.0f),
			Random.Range (-3.0f, 3.0f), Random.Range (2.0f, 2.5f));
		print(targetinst.transform.position);
		Destroy (gameObject);
	}
}
