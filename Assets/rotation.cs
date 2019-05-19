using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour {
	public static float playerRPM = 10000;
	public static float playerHitLoss = 0;
	float rpm;
	float timer = 0.0f;
	int seconds =0;
	// Use this for initialization
	void Start () {
		rpm = 10000.0f;
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		seconds = (int)timer % (60 * (1+ ((int)seconds/59)));
		Debug.Log (seconds);

		playerRPM = 10000 - ((100*seconds) + playerHitLoss);
		if (gameObject.name != "player") {
			rotate (degreesToMove (rpm));
		} else {
			rotate (degreesToMove (playerRPM));
		}
		Debug.Log (playerRPM);
	}
		
	float degreesToMove(float rpm){
		return rpm / 0.166666667f;
	}

	void rotate(float degs){
		transform.Rotate (new Vector3 (0.0f, (degs*Time.deltaTime)/10, 0.0f));
	}
}
