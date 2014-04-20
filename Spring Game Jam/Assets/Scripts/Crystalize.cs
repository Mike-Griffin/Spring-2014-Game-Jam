using UnityEngine;
using System.Collections;

public class Crystalize : MonoBehaviour {

	public Transform SpawnPoint;
	public GameObject Crystal;

	public void StartCrystalize(){

		//SpawnPoint.position = new Vector2(gameObject.transform.localPosition.x,
		//                                  gameObject.transform.localPosition.y + 1);
		Instantiate(Crystal, SpawnPoint.position, SpawnPoint.rotation);
	}
}