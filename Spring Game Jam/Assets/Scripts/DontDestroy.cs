using UnityEngine;
using System.Collections;

public class DontDestroy : MonoBehaviour {

	// Update is called once per frame
	void Update () {
	
		DontDestroyOnLoad (this.gameObject);
	}
}
