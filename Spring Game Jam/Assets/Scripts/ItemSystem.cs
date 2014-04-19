using UnityEngine;
using System.Collections;

public class ItemSystem : MonoBehaviour {
	
	public int ItemCountOne = 0;	//dedicated to Crystal Bomb
	public int ItemCountTwo = 0;	//dedicated to Basic Bomb
	
	//Item Picked Up
	void GetItem(int GetItemChoice){

		Debug.Log("ITEM GOT!");
		//Determine which item it is, and increase its count
		if(GetItemChoice == 0)
		{
			Debug.Log ("ITEM 1");
			ItemCountOne++;
		}
		else if(GetItemChoice == 1)
		{
			Debug.Log ("ITEM 2");
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
				Debug.Log ("USED ITEM");
				ItemCountOne--;
			}
			//else make bad noise
		}
		else if(ItemChoice == 1)
		{
			if(ItemCountTwo > 0)
			{
				//Use Item
				ItemCountTwo--;
			}
			//else make bad noise
			
		}
	}
}
