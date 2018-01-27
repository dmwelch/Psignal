using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftAndRight : MonoBehaviour {

	public float playerSpeed = 1.0f; //

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		Vector3 newPosition = transform.position;
		newPosition.x += Input.GetAxis("Horizontal") * playerSpeed *Time.deltaTime; 
		transform.position = newPosition;
	}
}
