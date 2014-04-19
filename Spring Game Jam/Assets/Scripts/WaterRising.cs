using UnityEngine;
using System.Collections;

public class WaterRising : MonoBehaviour {
	public float KeyDelay = 0.000f;
	private float height = 0;

	// Use this for initialization
	void Start () {
		StartCoroutine(IncreaseBox());
	}
	
	// Update is called once per frame

	public IEnumerator IncreaseBox()
	{
		while(true)
		{
			height += 10;
			yield return new WaitForSeconds(KeyDelay);
		}
	}

	void Update () {
	
	}
}
