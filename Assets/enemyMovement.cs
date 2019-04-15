using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour {
	float timer = 0.0f;
	int seconds = 0;
	bool moved = false;
	Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = this.gameObject.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		seconds = (int)timer % 60;
		if (seconds % 15 == 0 && !moved) {
			moved = true;
			rb.velocity = new Vector3 (Random.Range (-10.0f, 10.0f), 0.0f, Random.Range (-10.0f, 10.0f));

		} else if (seconds % 5 != 0 && moved || seconds % 5 == 0) {
			moved = false;
		}

	}
}
