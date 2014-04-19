using UnityEngine;
using System.Collections;

public class ItemSystem : MonoBehaviour {
	
	int ItemCountOne = 0;	//dedicated to Crystal Bomb
	int ItemCountTwo = 0;	//dedicated to Basic Bomb
	
	//Item Picked Up
	void GetItem(int ItemChoice){
		
		//Determine which item it is, and increase its count
		if(ItemChoice == 0)
			ItemCountOne++;
		
		else if(ItemChoice == 1)
			ItemCountTwo++;
		
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
