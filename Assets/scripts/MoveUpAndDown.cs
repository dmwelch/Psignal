using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUpAndDown : MonoBehaviour {

	public float speed;

	private Rigidbody2D rb2d;

	void Start() {
		rb2d = GetComponent<Rigidbody2D> ();
	}

	void FixedUpdate() {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector2 newPosition = transform.position;
		newPosition.x += moveHorizontal * speed;
		newPosition.y += moveVertical * speed;
		rb2d.MovePosition (newPosition);
	}
}
