using UnityEngine;
using System.Collections;

public class Crystalize : MonoBehaviour {

	public Transform SpawnPoint;
	public GameObject Crystal;

	public void StartCrystalize(){

		//Destroy(gameObject.collider);
		Instantiate(Crystal, SpawnPoint.position, SpawnPoint.rotation);
		GameObject.Find ("GameManager").SendMessageUpwards ("FloodFixed", SendMessageOptions.DontRequireReceiver);
	}
}