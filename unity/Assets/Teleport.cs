using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleport : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(){
		switch (SceneManager.GetActiveScene().name) {
			case "1": SceneManager.LoadScene("2"); break;
			case "2": SceneManager.LoadScene("3"); break;
			default: SceneManager.LoadScene("1"); break;
		}
	}	
}
