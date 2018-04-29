using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enddisplay : MonoBehaviour {

		Text scoretext;
		scoredestroy destroy;


		// Use this for initialization
		void Start () {
			scoretext = GetComponent<Text> ();
			destroy = FindObjectOfType<scoredestroy> ();
		}

		// Update is called once per frame
		void Update () {
			scoretext.text = "Score: " + destroy.score;
		}
}
