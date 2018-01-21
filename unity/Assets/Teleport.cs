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

		string sceneName = SceneManager.GetActiveScene().name;

		switch (sceneName) {
			case "1": sceneName = "2"; break;
			case "2": sceneName = "3"; break;
			default: sceneName = "1"; break;
		}

		Initiate.Fade(sceneName,Color.white,2.5f);
	}	
}
