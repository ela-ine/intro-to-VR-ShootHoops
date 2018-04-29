using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bottom : MonoBehaviour {

	public GameObject ringPrefab;
	Collider expected;
	GameObject ringinst;

	public void Expectations (Collider boom) {
		expected = boom;
		print ("expected run");
	}

	void OnTriggerEnter (Collider other) {
		
		GameObject oldring = GameObject.Find("RingBoard");

		if (other == expected) {
			scorekeeper score = FindObjectOfType<scorekeeper> ();
			score.IncrementScore(2);
			print ("trigger 2 run");

			ringinst = Instantiate (ringPrefab); // this doesn't work :(
			ringinst.transform.position = transform.position + new Vector3 (Random.Range (-2.0f, 2.0f),
				Random.Range (-2.0f, 2.0f), Random.Range (2.0f, 2.5f));
			print(ringinst.transform.position);
			Destroy (oldring);
		}
		
	}
}
