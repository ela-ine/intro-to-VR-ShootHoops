using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ringboardtrigger2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	void OnTriggerEnter(Collider bam) {
		ringboardtrigger bottomtrigger = GetComponentInChildren<ringboardtrigger> ();
		bottomtrigger.Expectations (bam);
		print("trigger 2 run");
	}

	// Update is called once per frame
	void Update () {
		
	}
}
