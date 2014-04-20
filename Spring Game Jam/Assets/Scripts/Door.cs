using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {
	bool floodFixed = false;
	// Use this for initialization
	void Start () {
		renderer.material.color = Color.grey;
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		if(Input.GetKeyDown(KeyCode.Space))
		{
			floodFixed = true;
		}
		if(floodFixed == true)
		{
			renderer.material.color = Color.yellow;
		}
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		if(collision.gameObject.tag == "Player" )
		{
			Debug.Log ("Player collides with door");
			GameObject.Find ("GameManager").SendMessageUpwards("LevelComplete", SendMessageOptions.DontRequireReceiver);
		}
	}

	void FloodFixed()
	{
		floodFixed = true;
	}
}
