using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayControler : MonoBehaviour {
	public float maxSpeed;
	public float jumpHeight;

	Rigidbody2D myBody;
	Animator myAnim;



	// Use this for initialization
	void Start () {
		// Mapped
		myBody = GetComponent<Rigidbody2D>	();
		myAnim = GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float move = Input.getAxis (" ");
	}
}
