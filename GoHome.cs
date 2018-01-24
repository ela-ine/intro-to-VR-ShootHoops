using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoHome : MonoBehaviour {

	public Vector2 location = new Vector2(0.0f, 0.0f);
	public Vector2 home = new Vector2 (0.0f, 0.0f);
	public bool isHome = false;
	public float distance = 0f;
	public Vector2 vdistance = new Vector2 (0.0f, 0.0f);

	// Use this for initialization
	void Start () {
		print ("you are here: " + location);
		home = new Vector2(Random.Range(-5, 5), Random.Range(-5, 5));
		print (home);
	}

	// Update is called once per frame
	void Update () {
		distance = Vector2.Distance(home,location);
		vdistance = home - location;
		if (isHome == false) {
			if (Input.GetKeyDown (KeyCode.UpArrow)) {
				location = location + new Vector2 (0, 1);
			}
			if (Input.GetKeyDown (KeyCode.DownArrow)) {
				location = location + new Vector2 (0, -1);
			}
			if (Input.GetKeyDown (KeyCode.RightArrow)) {
				location = location + new Vector2 (1, 0);
			}
			if (Input.GetKeyDown (KeyCode.LeftArrow)) {
				location = location + new Vector2 (-1, 0);
			}
			if (Input.anyKeyDown) {
				print ("you are now here: " + location);
				print ("you are " + distance + " " + vdistance + " spaces away");
			}

			if (location == home) {
				isHome = true;
				print ("you are home!");
			}
		}
	}
}
