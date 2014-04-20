using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {
	private float timer = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		timer += 1;
		if (Input.GetKeyDown(KeyCode.Space)) 
		{
			Application.LoadLevel (Application.loadedLevel - 1);
		}
	}
}
