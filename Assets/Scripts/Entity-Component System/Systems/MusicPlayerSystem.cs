using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayerSystem : MonoBehaviour {

	private bool playMusic = false; 
	// Use this for initialization
	void Awake () {
		if(playMusic == false)
		{
			DontDestroyOnLoad(this.gameObject);
		}
	}
}
