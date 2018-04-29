using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoredestroy : MonoBehaviour {
	public int score;
	// Use this for initialization
	void Start () {

		andscore old = FindObjectOfType<andscore> ();

		if (old) {
		  score = old.score;
		  Destroy(old.gameObject);
		}
	}

	// Update is called once per frame
	void Update () {

	}
}
