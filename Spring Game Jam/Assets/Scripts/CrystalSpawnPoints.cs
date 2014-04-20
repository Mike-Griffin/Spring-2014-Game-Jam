using UnityEngine;
using System.Collections;

public class CrystalSpawnPoints : MonoBehaviour {
	
	public bool L, U, R, D;
	public bool Checked = true;
	public int WaterLine = 0;
	public Transform targetObj;
	// Use this for initialization
	void Start(){

		Debug.Log (GameObject.Find("WaterCollider").GetComponent<WaterRising>().height);
	}                                             

	void OnTriggerStay2D(Collider2D collider)
	{
		if(collider.tag != "Player" && collider.tag != "Water" && collider.tag != "Bomb" && Checked == true)
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

		else if(gameObject.transform.position.y >= WaterLine && Checked == true)
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
		Checked = false;
	}

	public void OnTriggerEnter2D(Collider2D collider)
	{
		if(collider.tag != "Player" && collider.tag != "Water" && collider.tag != "Bomb")
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

		else if(gameObject.transform.position.y >= WaterLine)
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
