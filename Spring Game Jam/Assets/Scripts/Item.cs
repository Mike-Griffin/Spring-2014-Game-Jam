using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {

	public int ItemNumber = 0;
	public bool AllowedToGet = false;

	public bool CrystalBomb = false;
	public bool BasicBomb = false;

	void Start()
	{
		StartCoroutine(Timer());
	}

	public IEnumerator Timer(){

		yield return new WaitForSeconds(0.5f);
		AllowedToGet = true;
	}

	//When spawned retains CrystalBomb type
	public void CrystalBombOn(){

		CrystalBomb = true;
	}
	//Retains BasicBomb type
	public void BasicBombOn(){

		BasicBomb = true;
	}

	void OnCollisionEnter2D(Collision2D collider)
	{
		//If Player hits item, pick up item
		if(collider.gameObject.tag == "Player" && AllowedToGet == true)
		{
			collider.gameObject.SendMessageUpwards("GetItem", ItemNumber, SendMessageOptions.DontRequireReceiver);
			Destroy (this.gameObject);
		}

		//If CrystalBomb hits LeakPoint, begin crystalization
		else if(collider.gameObject.tag == "Leak" && CrystalBomb)
		{
			collider.gameObject.SendMessageUpwards("StartCrystalize", SendMessageOptions.DontRequireReceiver);
			Destroy (this.gameObject);
		}
		/*
		else if(collider.gameObject.tag == "Water" && BasicBomb)
		{
			Debug.Log ("This happens");
			collider.gameObject.SendMessageUpwards("RemoveAcid", SendMessageOptions.DontRequireReceiver);

		}
		*/
	}

	void WaterHit()
	{
		if(BasicBomb)
		{
			Destroy (this.gameObject);
			GameObject.Find("WaterCollider").SendMessageUpwards("RemoveAcid", SendMessageOptions.DontRequireReceiver);
		}

	}
}
