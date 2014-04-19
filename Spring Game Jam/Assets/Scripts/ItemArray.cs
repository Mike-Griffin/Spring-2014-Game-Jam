using UnityEngine;
using System.Collections;

public class ItemArray : MonoBehaviour {

	public int ArrayLength = 2;
	private int CurrentItem = 0;
	public double KeyDelay = 0.25;
	public int[] Item;


	// Use this for initialization
	void Start () {

		Item = new int[ArrayLength];
	}
	
	// Update is called once per frame
	void Update() {

		if(Input.GetKeyDown(KeyCode.A))
		{
			if(CurrentItem == 0)
			{
				CurrentItem = ArrayLength -1;
			}
			else CurrentItem--;	
		}
		else if(Input.GetKeyDown(KeyCode.D))
		{
			if(CurrentItem == ArrayLength - 1)
			{
				CurrentItem = 0;
			}
			else CurrentItem++;
		}
		Debug.Log (CurrentItem);
	
	}
}

