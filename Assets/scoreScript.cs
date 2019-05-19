using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class scoreScript : MonoBehaviour {
	public static int numberOfCollectibles = 0;
	public static int totalCol;
	Text score;
	// Use this for initialization
	void Start () {
		score = this.gameObject.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		score.text = "Collectibles: " + numberOfCollectibles + "/"+ totalCol;
		if (numberOfCollectibles == totalCol) {
			SceneManager.LoadScene (4);
		}
		if (rotation.playerRPM <= 0) {
			SceneManager.LoadScene (3);
		}
	}
}
