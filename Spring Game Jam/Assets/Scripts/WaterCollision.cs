using UnityEngine;
using System.Collections;

public class WaterCollision : MonoBehaviour {

	void OnTriggerEnter(Collider player)
	{
		if(player.tag == "Player")
			player.SendMessageUpwards("WaterOn", SendMessageOptions.DontRequireReceiver);
	}
	
	void OnTriggerExit(Collider player)
	{
		if(player.tag == "Player")
			player.SendMessageUpwards("WaterOff", SendMessageOptions.DontRequireReceiver);	
	}
}
