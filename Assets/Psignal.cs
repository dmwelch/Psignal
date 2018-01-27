using System.Collections;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using UnityEngine;

public class Psignal : MonoBehaviour {

	public float speed;
	private Rigidbody2D rb2d;
	public Matrix signal;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
		signal = GetComponent<Matrix> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
		rb2d.AddForce (movement * speed);
	}
}
