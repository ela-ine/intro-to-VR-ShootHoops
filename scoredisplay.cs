using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoredisplay : MonoBehaviour {

	Text scoretext;
	scorekeeper scorekeeper;


	// Use this for initialization
	void Start () {
		scoretext = GetComponent<Text> ();
		scorekeeper = FindObjectOfType<scorekeeper> ();
	}

	// Update is called once per frame
	void Update () {
		scorekeeper.text = "Score: " + scorekeeper.score;
	}
}
