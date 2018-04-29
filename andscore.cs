using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class andscore : MonoBehaviour {

	public int score = 0;

	public void IncrementScore(int num) {
		score += num;
		print ("Your score is: " + score);
	}


	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
