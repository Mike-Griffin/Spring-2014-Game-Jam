using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	bool grounded = false;
	bool inWater = false;
	public float LandMovementSpeed = 10;
	public float jumpForce = 10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		if(grounded)
		{
			if(Input.GetAxis ("Horizontal") > 0)
			{
				rigidbody2D.velocity = Vector2.right * LandMovementSpeed;
			}
			if(Input.GetAxis ("Horizontal") < 0)
			{
				rigidbody2D.velocity = -Vector2.right * LandMovementSpeed;
			}
		}

		if (grounded && Input.GetKeyDown (KeyCode.Space)) 
		{
			Jump();
			Debug.Log("On the ground");
		}
	}

	void WaterOn()
	{
		inWater = true;
	}

	void WaterOff()
	{
		inWater = false;
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "Platform") 
		{
			grounded = true;
		}
	}

	void Jump()
	{
		rigidbody2D.AddForce (Vector2.up * jumpForce);
		grounded = false;
	}
}
