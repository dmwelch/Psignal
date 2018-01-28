using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupDrop : MonoBehaviour {

	public float pickupDistance = 2.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Physics.Raycast (transform.position, transform.forward, pickupDistance)) {
			Debug.Log("Looking at Something");
		}
	}
}
