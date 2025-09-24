using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformerPlayerController : MonoBehaviour
{

	public float moveSpeed = 5f;	
	public float jumpForce = 10f; 
	public LayerMask groundLayer;
	public Transform groundCheck;
	public float groundCheckRadius = 0.2f;



	private Rigidbody2D rb;
	private float horizontalInput;
	private bool isGrounded;

    void Start()
    {
        	//get the ribigbody 2d component attached to gameobject
	rb = GetComponent<Rigidbody2D>();

	if (groundCheck == null)
	{
		Debug.LogError("GroundCheck not assigned to the player controller!");

	}



    }


    void Update()
    {
	// get input values for horizontal movement
        horizontalInput = Input.GetAxis("Horizontal");
	
	// check for jump input
	if (Input.GetButtonDown("Jump") && isGrounded)
	{
	//apply an upward force for jumping
	rb.velocity = new Vector2(rb.velocity.x, jumpForce);
	}


    }

	void FixedUpdate()
	{


	rb.velocity = new Vector2(horizontalInput * moveSpeed, rb.velocity.y);

	isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);

	if (horizontalInput > 0)
	{
	transform.localScale = new Vector3(1f, 1f, 1f); // right facing

	}

	else if (horizontalInput < 0)
	{
	transform.localScale = new Vector3(-1f, 1f, 1f);  // left facing
	}





	}
}
