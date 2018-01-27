using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateWaveSprites : MonoBehaviour {

	public GameObject spawnObject;
	public float displayAreaWidth;
	public float displayAreaHeight;
	public int resolution;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < resolution; i++) {
			Vector2 spawnPosition = transform.position;
			spawnPosition.x += i * (displayAreaWidth / resolution);
			spawnPosition.y += Mathf.Sin (spawnPosition.x);
			GameObject newObject = Instantiate (spawnObject, spawnPosition, transform.rotation) as GameObject;
			newObject.transform.parent = transform;
		}
			
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnDrawGizmos()
	{
		for (int i = 0; i < resolution; i++) {
			Vector2 spawnPosition = transform.position;
			spawnPosition.x += i * (displayAreaWidth / resolution);
			spawnPosition.y += Mathf.Sin (spawnPosition.x);
			Gizmos.DrawLine (spawnPosition + Vector2.left, spawnPosition + Vector2.right);
			Gizmos.DrawLine (spawnPosition + Vector2.up, spawnPosition + Vector2.down);
		}
	}
}
