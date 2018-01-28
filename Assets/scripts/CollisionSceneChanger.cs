﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionSceneChanger : MonoBehaviour {

	public string destination;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnColliderEnter2D(Collider2D collider) {
		
		SceneManager.LoadScene (destination);

	}

	void OnTriggerEnter2D(Collider2D collider) {
		SceneManager.LoadScene (destination);
	}
}
