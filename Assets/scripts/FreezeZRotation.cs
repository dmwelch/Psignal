using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeZRotation : MonoBehaviour {

	Rigidbody2D m_Rigidbody;
	Vector3 m_ZAxis;

	// Use this for initialization
	void Start () {
		m_Rigidbody = GetComponent<Rigidbody2D> ();
		m_Rigidbody.constraints = RigidbodyConstraints2D.FreezeRotation;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
