using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float moveSpeed;

	Rigidbody2D rb;
	Animator anim;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 movementVector = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

		if(movementVector != Vector2.zero) {
			anim.SetBool("isWalking", true);
			anim.SetFloat("input_x", movementVector.x);
			anim.SetFloat("input_y", movementVector.y);
		} else {
			anim.SetBool("isWalking", false);
		}

		rb.MovePosition(rb.position + movementVector * moveSpeed * Time.deltaTime);
	}
}
