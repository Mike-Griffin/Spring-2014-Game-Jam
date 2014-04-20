using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {
	bool floodFixed = false;
	public bool exitDoor;
	// Use this for initialization
	void Start () {
		if(exitDoor)
		{
			renderer.material.color = Color.black;
		}
		else
		{
			renderer.material.color = Color.white;
		}
			gameObject.collider2D.enabled = false;
	}

	// Update is called once per frame
	void FixedUpdate () 
	{
		/*
		if(Input.GetKeyDown(KeyCode.Space))
		{
			floodFixed = true;
		}
		*/
		if(floodFixed == true)
		{
			renderer.material.color = Color.white;
			gameObject.collider2D.enabled = true;
		}
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		if(collision.gameObject.tag == "Player" && floodFixed == true)
		{
			Debug.Log ("Player collides with door");
			GameObject.Find ("GameManager").SendMessageUpwards("LevelComplete", SendMessageOptions.DontRequireReceiver);
		}
	}

	void FloodFixed()
	{
		Debug.Log ("This should happen");
		floodFixed = true;
	}
}
