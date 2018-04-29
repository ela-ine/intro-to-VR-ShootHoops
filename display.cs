using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class display : MonoBehaviour {

	Text scoretext;
	andscore andscore;


	// Use this for initialization
	void Start () {
		scoretext = GetComponent<Text> ();
		andscore = FindObjectOfType<andscore> ();
	}

	// Update is called once per frame
	void Update () {
		scoretext.text = "Score: " + andscore.score;
	}
}
