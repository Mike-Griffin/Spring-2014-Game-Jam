using UnityEngine;
using System.Collections;

public class WaterCollision : MonoBehaviour {
	public bool acidic = true;
	//private bool removeAcid = false;
	private float thirdColor = .16f;
	private float KeyDelay = .05f;

	void Start()
	{
		if(acidic)
		{
			renderer.material.color = new Color(1,0.92f, thirdColor ,1);
		}
	}

	void RemoveAcid()
	{
		if(acidic)
		{
			StartCoroutine(AcidLoop());
		}
		acidic = false;
		//renderer.material.color = new Color(1,1,1,1);
	}

	public IEnumerator AcidLoop()
	{
		while(thirdColor < 1)
		{
			thirdColor += .01f;
			renderer.material.color = new Color(1,1,thirdColor,1);
			yield return new WaitForSeconds(KeyDelay);
		}
	}

	void OnTriggerEnter2D(Collider2D player)
	{
		if(player.tag == "Bomb")
		{
			player.SendMessageUpwards("WaterHit", SendMessageOptions.DontRequireReceiver);
		}

		if(player.tag == "Player")
		{
			if (acidic) 
			{
				GameObject.Find("GameManager").SendMessageUpwards("GameOver", SendMessageOptions.DontRequireReceiver);
			}
			//Debug.Log("PLAYER!");
			else
			{
				player.SendMessageUpwards("WaterOn", SendMessageOptions.DontRequireReceiver);
			}
		}
	}
	
	void OnTriggerExit2D(Collider2D player)
	{
		Debug.Log ("Exited water");
		if(player.tag == "Player")
			player.SendMessageUpwards("WaterOff", SendMessageOptions.DontRequireReceiver);	
	}
}
