using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPanUp : MonoBehaviour {

	public float speed = 1.0f;
	public int pause = 600;
	public float timeSinceStarted = 0.0f;


	// Use this for initialization
	void Start () {

		Vector3 newVelocity = Vector3.zero;
		newVelocity.y = speed;

	}
	
	// Update is called once per frame
	void Update () {
		timeSinceStarted++;
		if (timeSinceStarted > pause && transform.position.y < 17) {
			Vector3 newPosition = transform.position;
			newPosition.y += speed;
			transform.position = newPosition;
		}
	}
}
