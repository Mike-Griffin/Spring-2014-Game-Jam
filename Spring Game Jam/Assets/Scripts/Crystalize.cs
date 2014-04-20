using UnityEngine;
using System.Collections;

public class Crystalize : MonoBehaviour {

	public Transform SpawnPoint;
	public float SpawnDelay = 0.75f;
	public int xSpawnCap = 0;
	public int ySpawnCap = 0;
	public float x = 0f;
	public float y = 0f;
	public bool Crystalizing = false;
	public GameObject Crystal;

	public void StartCrystalize(){

		Crystalizing = true;
		StartCoroutine(LoopCrystalize());
	}

	// Use this for initialization
	public IEnumerator LoopCrystalize(){

		StartCoroutine(SetSpawnPoints());
		yield return new WaitForSeconds (0.01f);
		while(Crystalizing == true)
		{
			Debug.Log (x);

			yield return new WaitForSeconds(SpawnDelay);
		}
	}

	public IEnumerator SetSpawnPoints(){

		while(Crystalizing == true)
		{
			x = gameObject.transform.position.x;
			y = gameObject.transform.position.y;
			yield return new WaitForSeconds(SpawnDelay);

			x -= 1;
			SpawnPoint.position = new Vector2(x, y);
			SpawnCrystal ();
			x += 1;
			y += 1;
			SpawnPoint.position = new Vector2(x, y);
			SpawnCrystal ();
			yield return new WaitForSeconds(SpawnDelay);




		}

	}

	public void SpawnCrystal(){

		Instantiate(Crystal, SpawnPoint.position, SpawnPoint.rotation);
	}
}