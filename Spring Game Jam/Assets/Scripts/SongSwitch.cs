using UnityEngine;
using System.Collections;

public class SongSwitch : MonoBehaviour {

	public AudioClip[] MySong;
	private int CurrentSong = 0;

	// Use this for initialization
	void Start () {

		audio.clip = MySong[CurrentSong];
		audio.Play();
	}
	
	// Update is called once per frame
	void ChangeSong(int SongNumber){
		
		CurrentSong = SongNumber;
		audio.clip = MySong[CurrentSong];
		audio.Play();
	}
}
