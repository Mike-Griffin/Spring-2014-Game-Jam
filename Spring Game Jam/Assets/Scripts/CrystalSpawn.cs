using UnityEngine;
using System.Collections;

public class CrystalSpawn : MonoBehaviour {

	public GameObject SpawnPointL;
	public GameObject SpawnPointR;
	public GameObject SpawnPointU;
	public GameObject SpawnPointD;

	public bool LeftFree, UpFree, RightFree, DownFree;

	public float SpawnDelay = 0.5f;
	public float MiniDelay = 0.124f;
	public GameObject Crystal;

	public void Start(){

		LeftFree = UpFree = RightFree = DownFree = true;
		StartCoroutine(SpawnCrystals());
	}

	public void OnTriggerStay2D(Collider2D collider)
	{
		if(collider.tag != "Player" && collider.tag != "Water" && collider.tag != "Spawn"
		   && collider.tag != "SpawnLeft" && collider.tag != "SpawnRight")
		{
			Destroy (gameObject);
		}
	}
	
	// Use this for initialization
	public IEnumerator SpawnCrystals(){

		yield return new WaitForSeconds(SpawnDelay);

		if(LeftFree)
		{
			Instantiate(Crystal, SpawnPointL.transform.position, SpawnPointL.transform.rotation);
			//SpawnPointL.SetActive (false);
			yield return new WaitForSeconds(MiniDelay);
		}
		if(UpFree)
		{
			Instantiate(Crystal, SpawnPointU.transform.position, SpawnPointU.transform.rotation);
			//SpawnPointU.SetActive (false);
			yield return new WaitForSeconds(MiniDelay);
		}

		if(RightFree)
		{
			Instantiate(Crystal, SpawnPointR.transform.position, SpawnPointR.transform.rotation);
			//SpawnPointR.SetActive (false);
			yield return new WaitForSeconds(MiniDelay);
		}
		if(DownFree)
		{
			Instantiate(Crystal, SpawnPointD.transform.position, SpawnPointD.transform.rotation);
			//SpawnPointD.SetActive (false);
		}
	}
	//SDirection values:
	//1 = L, 2 = U, 3 = R, 4 = D;
	public void CheckNotFree(int SDirection){
		if(SDirection == 1)
		{
			LeftFree = false;
		}
		if(SDirection == 2)
		{
			UpFree = false;
		}
		if(SDirection == 3)
		{
			RightFree = false;
		}
		if(SDirection == 4)
		{
			DownFree = false;
		}

	}
	
}
