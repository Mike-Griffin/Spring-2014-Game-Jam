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
	}

	void GameOver()
	{
		Application.LoadLevel ("Game Over");
	}
}
