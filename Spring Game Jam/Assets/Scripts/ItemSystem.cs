using UnityEngine;
using System.Collections;

public class ItemSystem : MonoBehaviour {

	public GameObject ItemOne;
	public GameObject ItemTwo;

	public Transform SpawnPoint;

	public int ItemCountOne = 0;	//dedicated to Crystal Bomb
	public int ItemCountTwo = 0;	//dedicated to Basic Bomb

	void Update(){

		if(Input.GetKeyDown(KeyCode.A))
			FacingLeft ();
		else if(Input.GetKeyDown (KeyCode.D))
			FacingRight ();
	}

	void FacingRight(){

		SpawnPoint.position = new Vector2(gameObject.transform.localPosition.x + 1.2f,
		                                  gameObject.transform.localPosition.y);
	}

	void FacingLeft(){

		SpawnPoint.position = new Vector2(gameObject.transform.localPosition.x - 1.2f,
		                                  gameObject.transform.localPosition.y);
	}

	//Item Picked Up
	void GetItem(int GetItemChoice){

		Debug.Log("ITEM GOT!");
		//Determine which item it is, and increase its count
		if(GetItemChoice == 0)
		{
			Debug.Log ("ITEM 0");
			ItemCountOne++;
		}
		else if(GetItemChoice == 1)
		{
			Debug.Log ("ITEM 1");
			ItemCountTwo++;
		}
		
	}
	
	//Item Used from ItemArray.cs
	public void UseItem(int ItemChoice){
		
		//Determine which item it is
		if(ItemChoice == 0)
		{
			//If item is there use it and decrease count
			if(ItemCountOne > 0)
			{
				//Use Item
				Debug.Log ("USED ITEM 0");
				GameObject var1 = Instantiate(ItemOne, SpawnPoint.position, SpawnPoint.rotation) as GameObject;
				var1.SendMessageUpwards("CrystalBombOn", SendMessageOptions.DontRequireReceiver);
				ItemCountOne--;
			}
			//else make bad noise
		}
		else if(ItemChoice == 1)
		{
			if(ItemCountTwo > 0)
			{
				//Use Item
				Debug.Log ("USED ITEM 1");
				GameObject var2 = Instantiate(ItemTwo, SpawnPoint.position, SpawnPoint.rotation) as GameObject;
				var2.SendMessageUpwards("BasicBombOn", SendMessageOptions.DontRequireReceiver);
				ItemCountTwo--;
			}
			//else make bad noise
			
		}
	}
}
