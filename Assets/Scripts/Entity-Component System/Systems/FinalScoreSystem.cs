using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class FinalScoreSystem : MonoBehaviour {
	public Text Score; 
	// Use this for initialization
	void Start () {
		float scoreEarned = PlayerPrefs.GetFloat("scoreEarned"); 
		Score.text = "Score: " + Mathf.Round(scoreEarned); 
	}
}
