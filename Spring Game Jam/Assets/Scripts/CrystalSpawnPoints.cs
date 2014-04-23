﻿using UnityEngine;
using System.Collections;

public class CrystalSpawnPoints : MonoBehaviour {
	
	public bool L, U, R, D;
	public bool Checked = true;
	public float WaterLine = 0;
	public Transform targetObj;
	// Use this for initialization
	void Start(){

		WaterLine = GameObject.Find("WaterCollider").GetComponent<WaterRising>().actualHeight;
		Debug.Log (GameObject.Find("WaterCollider").GetComponent<WaterRising>().actualHeight);

	}                                             

	void OnTriggerStay2D(Collider2D collider)
	{
		if(collider.tag != "Player" && collider.tag != "Water" && collider.tag != "Bomb" && Checked == true)
		{
			if(L)
			{
				transform.parent.SendMessageUpwards("CheckNotFree", 1, 
			                                  	SendMessageOptions.DontRequireReceiver);
			}
			else if(U && collider.tag != "SpawnLeft" && collider.tag!= "SpawnRight")
			{

				transform.parent.SendMessageUpwards("CheckNotFree", 2, 
				                                    SendMessageOptions.DontRequireReceiver);
			}
			else if(R)
			{
				transform.parent.SendMessageUpwards("CheckNotFree", 3, 
				                                    SendMessageOptions.DontRequireReceiver);
			}
			else if(D && collider.tag != "SpawnLeft" && collider.tag!= "SpawnRight")
			{
				transform.parent.SendMessageUpwards("CheckNotFree", 4, 
				                                    SendMessageOptions.DontRequireReceiver);

			}
		}

		else if(gameObject.transform.position.y >= WaterLine && Checked == true)
		{
			Debug.Log ("WATERLINE");
			if(L)
			{
				transform.parent.SendMessageUpwards("CheckNotFree", 1, 
					                                    SendMessageOptions.DontRequireReceiver);
			}
			else if(U && collider.tag != "SpawnLeft" && collider.tag!= "SpawnRight")
			{
				transform.parent.SendMessageUpwards("CheckNotFree", 2, 
				                                    SendMessageOptions.DontRequireReceiver);
			}
			else if(R)
			{
				transform.parent.SendMessageUpwards("CheckNotFree", 3, 
					                                    SendMessageOptions.DontRequireReceiver);
			}
			else if(D && collider.tag != "SpawnLeft" && collider.tag!= "SpawnRight")
			{
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
					transform.parent.SendMessageUpwards("CheckNotFree", 1, 
					                                    SendMessageOptions.DontRequireReceiver);
				}
				else if(U && collider.tag != "SpawnLeft" && collider.tag!= "SpawnRight")
				{
					transform.parent.SendMessageUpwards("CheckNotFree", 2, 
					                                    SendMessageOptions.DontRequireReceiver);
				}
				else if(R)
				{
					transform.parent.SendMessageUpwards("CheckNotFree", 3, 
					                                    SendMessageOptions.DontRequireReceiver);
				}
				else if(D && collider.tag != "SpawnLeft" && collider.tag!= "SpawnRight")
				{
					transform.parent.SendMessageUpwards("CheckNotFree", 4, 
					                                    SendMessageOptions.DontRequireReceiver);
					
				}
			}

		else if(gameObject.transform.position.y >= WaterLine)
		{
			if(L)
			{
				transform.parent.SendMessageUpwards("CheckNotFree", 1, 
				                                    SendMessageOptions.DontRequireReceiver);
			}
			else if(U && collider.tag != "SpawnLeft" && collider.tag!= "SpawnRight")
			{
				transform.parent.SendMessageUpwards("CheckNotFree", 2, 
			                                    SendMessageOptions.DontRequireReceiver);
			}
			else if(R)
			{
				transform.parent.SendMessageUpwards("CheckNotFree", 3, 
				                                    SendMessageOptions.DontRequireReceiver);
			}
			else if(D && collider.tag != "SpawnLeft" && collider.tag!= "SpawnRight")
			{
				transform.parent.SendMessageUpwards("CheckNotFree", 4, 
					                                    SendMessageOptions.DontRequireReceiver);
					
			}
		}
	}
}
