using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballaudio : MonoBehaviour {

	void OnCollisionEnter (Collision collision) {
		AudioSource audio = GetComponent<AudioSource> ();
		audio.Play (); 
	}
}
