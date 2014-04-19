using UnityEngine;
using System.Collections;

public class WaterCollision : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D player)
	{
		Debug.Log("Entered");
		if(player.tag == "Player")
		{
			Debug.Log("PLAYER!");
			player.SendMessageUpwards("WaterOn", SendMessageOptions.DontRequireReceiver);
		}
	}
	
	void OnTriggerExit2D(Collider2D player)
	{
		if(player.tag == "Player")
			player.SendMessageUpwards("WaterOff", SendMessageOptions.DontRequireReceiver);	
	}
}
