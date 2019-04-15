﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {
	Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = gameObject.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		move ();
	}

	void move() {
		if (Input.GetKey ("w")) {
			rb.velocity = new Vector3 (rb.velocity.x, 0.0f, 8.0f);
		}
		if (Input.GetKey ("s")) {
			rb.velocity = new Vector3 (rb.velocity.x, 0.0f, -8.0f);
		}
		if (Input.GetKey ("d")) {
			rb.velocity = new Vector3 (8.0f, 0.0f, rb.velocity.z);
		}
		if (Input.GetKey ("a")) {
			rb.velocity = new Vector3 (-8.0f, 0.0f, rb.velocity.z);
		}
	}

	void OnCollisionEnter(Collision c){
		// credit to answers.unity.com//questions.1100879/push-object-in-opposite-direction-of-collision.html
		if (c.gameObject.tag == "enemy" ) {
			Debug.Log ("hit");
			Vector3 dir = c.contacts [0].point - transform.position;

			dir = -dir.normalized;

			rb.AddForce (-rb.velocity * 100);
			rotation.playerRPM -= 300;
		}
	}
}
