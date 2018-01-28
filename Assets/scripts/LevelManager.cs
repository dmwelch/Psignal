using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public string levelname;
	public static int Level1Score;
	public static int Level2Score;
	public static int Level3Score;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		float score = 0;
		foreach (GameObject emitter in GameObject.FindGameObjectsWithTag("Emitter")) {
			EmitterBehavior EmitterScript = emitter.GetComponent<EmitterBehavior>();
			score += EmitterScript. getAmplitude();
		}
		if (levelname == "Level1") {
			Level1Score = (int) score;
		}
		if (levelname == "Level2") {
			Level2Score = (int) score;
		}
		if (levelname == "Level3") {
			Level3Score = (int) score;
		}
	}
}
