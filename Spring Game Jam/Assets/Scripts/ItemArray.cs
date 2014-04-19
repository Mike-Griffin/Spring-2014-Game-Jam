using UnityEngine;
using System.Collections;

public class ItemArray : MonoBehaviour {

	public int ArrayLength = 2;
	public int CurrentItem = 0;
	private float KeyDelay = 0.000f;
	public int[] Item;


	// Use this for initialization
	void Start () {
		
		Item = new int[ArrayLength];
		StartCoroutine(ArrayLoop());
	}
	
	// Update script
	public IEnumerator ArrayLoop() {

		while(true)
		{
			//Scroll left through Inventory
			if(Input.GetKeyDown(KeyCode.Q))
			{
				if(CurrentItem == 0)
				{
					CurrentItem = ArrayLength -1;
				}
				else CurrentItem--;	
			}
			//Scroll right through Inventory
			else if(Input.GetKeyDown(KeyCode.E))
			{
				if(CurrentItem == ArrayLength - 1)
				{
					CurrentItem = 0;
				}
				else CurrentItem++;
			}
			//Use selected item
			else if(Input.GetKeyDown (KeyCode.J))
			{
				ItemSystem itemSystem = GetComponent<ItemSystem>();
				itemSystem.UseItem(CurrentItem);
			}

			yield return new WaitForSeconds(KeyDelay);
		}
	}
}

