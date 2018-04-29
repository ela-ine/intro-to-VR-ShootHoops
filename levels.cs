using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levels : MonoBehaviour {
	int currentIndex;
	float time = 15.0f;

	// Use this for initialization
	void Start () {

		currentIndex = SceneManager.GetActiveScene().buildIndex;

	}
	
	// Update is called once per frame
	void Update () {
		if (currentIndex == 1){
			time -= Time.deltaTime;
			if (time <= 0) {
				LoadNextScene ();
			}
		}

	}

	public void LoadNextScene () {
		SceneManager.LoadScene (currentIndex + 1);
	}

	public void LoadPreviousScene () {
		print (currentIndex);
		SceneManager.LoadScene (currentIndex - 1);
	}
}
