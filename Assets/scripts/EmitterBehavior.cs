using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmitterBehavior : MonoBehaviour {

	public float amplitude;
	public int frequency;
	public int strength;

	// Use this for initialization
	void Start () {
		amplitude = strength / 100;
	}

	// Update is called once per frame
	void Update () {
		float totalDistance = 0;
		foreach (GameObject emitter in GameObject.FindGameObjectsWithTag("Emitter")) {
			if (emitter != gameObject) {
				float aDistance = EuclideanDistance (gameObject, emitter);
				totalDistance += aDistance;
			}
		}
		amplitude = strength / totalDistance;
	}
	
	public float getAmplitude() {
		return amplitude;
	}

	float EuclideanDistance(GameObject thisObject, GameObject anotherObject) {
		return 
			Mathf.Sqrt (
				Mathf.Pow(
					(thisObject.transform.position.x - anotherObject.transform.position.x),2
				) + Mathf.Pow(
					(thisObject.transform.position.y - anotherObject.transform.position.y),2
				)
			);
	}
}
