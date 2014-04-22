using UnityEngine;
using System.Collections;

public class ItemArray : MonoBehaviour {

	public int ArrayLength = 2;
	public int CurrentItem = 0;
	public int ItemOneCount = 0;
	public int ItemTwoCount = 0;
	private float KeyDelay = 0.01f;
	public int[] Item;

	public GameObject GUIItem_Empty;
	public GameObject GUIItem_0;
	public GameObject GUIItem_1;


	// Use this for initialization
	void Start () {
		
		Item = new int[ArrayLength];
		GUIItem_Empty.SetActive(true);
		GUIItem_Empty.SetActive (false);
		GUIItem_Empty.SetActive (false);
		StartCoroutine(ArrayLoop());
	}

	public void ChangeCurrent(int NewCurrent){

		CurrentItem = NewCurrent;
	}

	public void AddCount(int item){

		GUIItem_Empty.SetActive (false);
		if(item == 0)
			ItemOneCount++;
		if(item == 1)
			ItemTwoCount++;
	}

	public void MinusCount(int item){

		if(item == 0)
			ItemOneCount--;
		if(item == 1)
			ItemTwoCount--;
	}
	
	// Update script
	public IEnumerator ArrayLoop() {

		while(true)
		{	
			if(ItemOneCount <= 0 && ItemTwoCount <= 0)
			{
				GUIItem_Empty.SetActive(true);
				GUIItem_0.SetActive(false);
				GUIItem_1.SetActive(false);
			}
			if(CurrentItem == 0 && ItemOneCount > 0)
			{
				GUIItem_0.SetActive(true);
				GUIItem_1.SetActive(false);
			}

			if(CurrentItem == 1 && ItemTwoCount > 0)
			{
				GUIItem_0.SetActive(false);
				GUIItem_1.SetActive(true);
			}
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

