using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class endScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public void OnMouseDown() {
		if (this.gameObject.tag == "Finish") {
			SceneManager.LoadScene (0);
		} else if (this.gameObject.name == "instructions") {
			SceneManager.LoadScene (1);
		} else {
			SceneManager.LoadScene (2);
		}
	}


}
