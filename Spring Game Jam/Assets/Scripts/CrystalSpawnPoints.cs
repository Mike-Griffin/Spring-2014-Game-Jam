using UnityEngine;
using System.Collections;

public class CrystalSpawnPoints : MonoBehaviour {
	
	public bool L, U, R, D;
	public bool Checked = true;
	// Use this for initialization

	void OnTriggerStay2D(Collider2D collider)
	{
		if(collider.tag != "Player" && collider.tag != "Water" && Checked == true)
		{
			if(L)
			{
				Debug.Log ("STOP SPAWNING!!!");
				transform.parent.SendMessageUpwards("CheckNotFree", 1, 
			                                  	SendMessageOptions.DontRequireReceiver);
			}
			else if(U && collider.tag != "SpawnLeft" && collider.tag!= "SpawnRight")
			{
				Debug.Log ("STOP SPAWNING!!!");
				transform.parent.SendMessageUpwards("CheckNotFree", 2, 
				                                    SendMessageOptions.DontRequireReceiver);
			}
			else if(R)
			{
				Debug.Log ("STOP SPAWNING!!!");
				transform.parent.SendMessageUpwards("CheckNotFree", 3, 
				                                    SendMessageOptions.DontRequireReceiver);
			}
			else if(D && collider.tag != "SpawnLeft" && collider.tag!= "SpawnRight")
			{
				Debug.Log ("STOP SPAWNING!!!");
				transform.parent.SendMessageUpwards("CheckNotFree", 4, 
				                                    SendMessageOptions.DontRequireReceiver);

			}
			Checked = false;
		}
	}
	void OnTriggerEnter2D(Collider2D collider)
	{
		if(collider.tag != "Player" && collider.tag != "Water")
			{
				if(L)
				{
					Debug.Log ("STOP SPAWNING!!!");
					transform.parent.SendMessageUpwards("CheckNotFree", 1, 
					                                    SendMessageOptions.DontRequireReceiver);
				}
				else if(U && collider.tag != "SpawnLeft" && collider.tag!= "SpawnRight")
				{
					Debug.Log ("STOP SPAWNING!!!");
					transform.parent.SendMessageUpwards("CheckNotFree", 2, 
					                                    SendMessageOptions.DontRequireReceiver);
				}
				else if(R)
				{
					Debug.Log ("STOP SPAWNING!!!");
					transform.parent.SendMessageUpwards("CheckNotFree", 3, 
					                                    SendMessageOptions.DontRequireReceiver);
				}
				else if(D && collider.tag != "SpawnLeft" && collider.tag!= "SpawnRight")
				{
					Debug.Log ("STOP SPAWNING!!!");
					transform.parent.SendMessageUpwards("CheckNotFree", 4, 
					                                    SendMessageOptions.DontRequireReceiver);
					
				}
			}
		}
}
