using UnityEngine;
using System.Collections;

public class WaterRising : MonoBehaviour {
	public float KeyDelay = 0.000f;
	private float height = 0;
	public float increment = .001f;
	//BoxCollider2D collider;

	// Use this for initialization
	void Start () {

		//collider = (BoxCollider2D)this.gameObject.collider2D;
		height = gameObject.transform.localScale.y;
		StartCoroutine(IncreaseBox());
	}
	
	// Update is called once per frame

	public IEnumerator IncreaseBox()
	{
		while(true)
		{
			Debug.Log ("This code is being executed");
			height += increment;
			gameObject.transform.localScale = new Vector2(gameObject.transform.localScale.x, height);
			//gameObject.transform.position = new Vector2(0, 1 - height / 2);
			yield return new WaitForSeconds(KeyDelay);
		}
	}

	void Update () {
	
	}
}
