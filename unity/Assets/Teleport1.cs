using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(){
		GameObject.FindGameObjectWithTag("Player").transform.position =
			GameObject.Find("Level2Spawn").transform.position;
	}	
}
