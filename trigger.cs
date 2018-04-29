using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	void OnTriggerEnter(Collider bam) {
		ringboardspawner bottomtrigger = GetComponentInChildren<bottom> ();
		bottomtrigger.Expectations (bam);
		print("trigger 2 run");
	}

	// Update is called once per frame
	void Update () {
		
	}
}
