using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    
    //How fast will the player move around the scene
	public float moveSpeed;
    
    //Set the layer that the player will check for inspections on
    [SerializeField]
    private LayerMask interactiveLayerMask = -1;

    //What direction is the player facing?
    private enum directions
    {
        left, right, up, down
    };
    private directions lastDirection;

    Rigidbody2D rb;
	Animator anim;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();

        lastDirection = directions.down;
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 movementVector = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

		if(movementVector != Vector2.zero){
			anim.SetBool("isWalking", true);
			anim.SetFloat("input_x", movementVector.x);
			anim.SetFloat("input_y", movementVector.y);

            //Find the direction
            if(Mathf.Abs(movementVector.x) > Mathf.Abs(movementVector.y)){
                if (movementVector.x > 0)
                    lastDirection = directions.right;
                else
                    lastDirection = directions.left;
            }
            else{
                if (movementVector.y > 0)
                    lastDirection = directions.up;
                else
                    lastDirection = directions.down;
            }

        } else {
			anim.SetBool("isWalking", false);
		}

        //Ok, the enum probably isn't the simplest way of doing this,
        //But it is at least extensible
        Vector2 inspectRayDirection;
        switch (lastDirection)
        {
            case directions.right:
                inspectRayDirection = new Vector2(1, 0);
                break;
            case directions.left:
                inspectRayDirection = new Vector2(-1, 0);
                break;
            case directions.up:
                inspectRayDirection = new Vector2(0, 1);
                break;
            default:
            case directions.down:
                inspectRayDirection = new Vector2(0, -1);
                break;
        }

        RaycastHit2D raycast_hit = Physics2D.Raycast(rb.position, inspectRayDirection, 1, interactiveLayerMask);
        Debug.DrawRay(rb.position, inspectRayDirection, Color.green);
        if (raycast_hit.collider != null)
        {
            if(Input.GetButtonDown("Inspect"))
            {
                Debug.Log("Hit");
            }
        }

        rb.MovePosition(rb.position + movementVector * moveSpeed * Time.deltaTime);
	}
}
