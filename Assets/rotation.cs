using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour {
	public static float playerRPM = 5000;
	float rpm;
	float timer = 0.0f;
	int seconds = 0;
	int oldSeconds = 0;
	// Use this for initialization
	void Start () {
		rpm = 5000.0f;
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		seconds = (int)timer % 60;
		rotate (degreesToMove (rpm));
	}
		
	float degreesToMove(float rpm){
		return rpm / 0.166666667f;
	}

	void rotate(float degs){
		transform.Rotate (new Vector3 (0.0f, degs*Time.deltaTime, 0.0f));
	}
}
