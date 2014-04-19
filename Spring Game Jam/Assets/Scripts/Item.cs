using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {

	public int ItemNumber = 0;

	void OnCollisionEnter2D(Collision2D player)
	{
		if(player.gameObject.tag == "Player")
		{
			player.gameObject.SendMessageUpwards("GetItem", ItemNumber, SendMessageOptions.DontRequireReceiver);
			Destroy (this.gameObject);
		}
	}
}
