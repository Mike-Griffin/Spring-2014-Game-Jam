using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	public string LoadLevel ="";
	private bool levelComplete = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(levelComplete)
		{
			Application.LoadLevel (LoadLevel);
		}
	}

	void LevelComplete()
	{
		levelComplete = true;
		Debug.Log ("Level Cleared");
	}

	void GameOver()
	{
		Application.LoadLevel (Application.loadedLevel + 1);
	}

	void FloodFixed()
	{
		GameObject.Find ("WaterCollider").SendMessageUpwards ("FloodFixed", SendMessageOptions.DontRequireReceiver);
		GameObject.Find ("Door").SendMessageUpwards ("FloodFixed", SendMessageOptions.DontRequireReceiver);
	}
}
