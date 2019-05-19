using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camMove : MonoBehaviour {
	GameObject player;
	GameObject Player;
	int dir = 1;
	// Use this for initialization
	void Start () {
		player = GameObject.Find ("player");
		Player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("e")) {
			transform.RotateAround (player.transform.position, Vector3.down, -90.0f);
		} else if (Input.GetKey ("q")) {
			transform.RotateAround (player.transform.position, Vector3.down, 90.0f);
		}
	}
}
