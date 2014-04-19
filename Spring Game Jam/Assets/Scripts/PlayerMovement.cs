using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	bool grounded = false;
	bool inWater = false;
	public float landMovementSpeed = 10;
	public float waterMovementSpeed = 10;
	public float jumpForce = 10;
	public float waterForce = 10;
	private float movementSpeed = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		if (!inWater) 
		{
			movementSpeed = landMovementSpeed;
		}
		else
		{
			movementSpeed = waterMovementSpeed;
			grounded = true;
		}
		if(grounded)
		{
			if(Input.GetAxis("Horizontal") > 0)
			{
				rigidbody2D.velocity = Vector2.right * movementSpeed;
			}
			if(Input.GetAxis("Horizontal") < 0)
			{
				rigidbody2D.velocity = -Vector2.right * movementSpeed;
			}
		}

		if (!inWater && grounded && Input.GetKeyDown (KeyCode.Space)) 
		{
			Jump();
			//Debug.Log("On the ground");
		}

		if(inWater)
		{
			rigidbody2D.AddForce(Vector2.up * waterForce);
			if(Input.GetAxis("Vertical") > 0)
			{
				transform.Translate(Vector2.up * movementSpeed * Time.deltaTime);
				//rigidbody2D.velocity = Vector2.up * movementSpeed;
			}

			if(Input.GetAxis("Vertical") < 0)
			{
				transform.Translate(Vector2.up * -movementSpeed * Time.deltaTime);
				//transform.Translate(Vector2(0, -movementSpeed) * Time.deltaTime);
				//rigidbody2D.velocity = -Vector2.up * movementSpeed;
			}
		}
	}

	void WaterOn()
	{
		inWater = true;
		grounded = true;
	}

	void WaterOff()
	{
		inWater = false;
		grounded = true;

	}

	void GroundedOn()
	{

		grounded = true;
	}

	void GroundedOff()
	{
		Debug.Log ("Grounded Off");
		grounded = false;
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "Platform") 
		{
		//	grounded = true;
		}
	}

	void OnCollisionExit2D(Collision2D collision)
	{

		if(collision.gameObject.tag == "Platform")
		{
		//	grounded = false;
		}

	}

	void Jump()
	{
		rigidbody2D.AddForce (Vector2.up * jumpForce);
		grounded = false;
	}
}
