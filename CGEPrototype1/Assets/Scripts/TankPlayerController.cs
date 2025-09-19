using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankPlayerController : MonoBehaviour
{

	//  try settubg thus ti 8 in the inspector
	// float to hold speed of our tank player

public float speed;

	// a float for our turn speed
	// try setting this to 100 in the inspector

public float turnSpeed;

	// variables for input

public float horizontalInput;
public float verticalInput;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       

	// move forward
	// transform.Translate(1,0,0); 
	// this does the same thing
	// transform.Translate(Vector3.right);


	//transform.Translate(Vector3.right * Time.deltaTime * speed);
	// move forward at 8 m/s since speed is 8

	// get input in Update()

	horizontalInput = Input.GetAxis("Horizontal");
	verticalInput = Input.GetAxis("Vertical");

	// move player forward with vertical input 

	transform.Translate(Vector2.right * Time.deltaTime * speed * verticalInput);

	// rotate player with horizontal input


		
	

	//rotate player with horizontal input but reverse direction when moving backwards

		if (verticalInput < 0 )
		{
	transform.Rotate(Vector3.back, -turnSpeed * Time.deltaTime * horizontalInput);
		}

		else 
		{
	transform.Rotate(Vector3.back, turnSpeed * Time.deltaTime * horizontalInput);
		}


    }
}
