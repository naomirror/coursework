using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class rpmDrain : MonoBehaviour {
	public Image bar;
	float fill;
	// Use this for initialization
	void Start () {
		fill = 1f;
	}
	// 1.00 = full, 0.9 == 90%, 0.01 in rpm = 100/5000 = 1/50 
	// Update is called once per frame
	void Update () {
		fill = (rotation.playerRPM / 10000);
		bar.fillAmount = fill;
	}
}
