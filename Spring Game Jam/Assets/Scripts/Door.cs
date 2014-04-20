using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {
	bool levelCleared = false;
	// Use this for initialization
	void Start () {
		renderer.material.color = Color.grey;
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		if(Input.GetKeyDown(KeyCode.Space))
		{
			levelCleared = true;
		}
		if(levelCleared == true)
		{
			renderer.material.color = Color.yellow;
		}
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		if(collision.gameObject.tag == "Player")
		{
			GameObject.Find ("Game Manager").SendMessageUpwards("Level Complete", SendMessageOptions.DontRequireReceiver);
		}
	}
}
