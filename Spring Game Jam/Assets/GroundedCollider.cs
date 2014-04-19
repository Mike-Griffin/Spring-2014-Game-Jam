using UnityEngine;
using System.Collections;

public class GroundedCollider : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D hit)
	{
		//Debug.Log("Entered");
		if(hit.gameObject.tag == "Platform")
		{
			//Debug.Log("PLAYER!");
			transform.parent.SendMessageUpwards("GroundedOn", SendMessageOptions.DontRequireReceiver);
		}
	}
	
	void OnTriggerExit2D(Collider2D hit)
	{

		if(hit.gameObject.tag == "Platform")
		{
			//Debug.Log ("exited");
			transform.parent.SendMessageUpwards("GroundedOff", SendMessageOptions.DontRequireReceiver);	
		}

	}
}
