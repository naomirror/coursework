using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelGen : MonoBehaviour {
	public GameObject env;
	public GameObject sEnv;
	public GameObject enemy;
	// Use this for initialization
	void Start () {
		for (int h = 0; h < 100; h++) {
			
			for (int w = 1; w < 100; w++) {
				if (Random.Range (0, 100) <= 1) {
					Instantiate (sEnv, new Vector3 (w, 0, h), Quaternion.identity);

				} else {
					Instantiate (env, new Vector3 (w, 0, h), Quaternion.identity);
				}

				if (Random.Range (0, 1000) <= 1) {
					Instantiate (enemy, new Vector3 (w, 1.1f, h), Quaternion.identity);
				}
				if (w == 99 || w == 1) {
					Instantiate (env, new Vector3 (w, 1, h), Quaternion.identity);
				} else if (h == 0 || h == 99) {
					Instantiate	(env, new Vector3 (w, 1, h), Quaternion.identity);
				}
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
