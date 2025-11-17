using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownPlayerController : MonoBehaviour
{
	//adjust this value in inspector to set players movement speed
	public float moveSpeed = 5f;

	private Rigidbody2D rb;
	private  Vector2 movement;




    // Start is called before the first frame update
    void Start()
    {
	//get rigidbody comp attached to gameobject
        rb = GetComponent<Rigidbody2D>();
    }




    // Update is called once per frame
    void Update()
    {
		// use getaxisraw so input is either a 1 zero or -1
        movement.x =Input.GetAxisRaw("Horizontal");
	movement.y=Input.GetAxisRaw("Vertical");

		//normalize movement vector to prevent faster diagonal movement
	movement.Normalize();

    }
void FixedUpdate()
{
		rb.velocity = new Vector2(movement.x * moveSpeed, movement.y * moveSpeed);
}
}
