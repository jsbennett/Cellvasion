using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Unlockables : MonoBehaviour {

	public Text Tier1; 
	public Text Tier2;
	public Text Tier3;
	public Text Tier4;
	public Text Tier5;
	
	// Use this for initialization
	void Start () {
	
		float scoreEarned = PlayerPrefs.GetFloat("scoreEarned"); 
		if(scoreEarned >=100)
		{
			Tier1.text = ""; 
		}
		else if (scoreEarned >=500)
		{
			Tier2.text = ""; 
		}
		else if(scoreEarned >=1000)
		{
			Tier3.text = ""; 
		}
		else if(scoreEarned >= 2000)
		{
			Tier4.text = "";
		}
		else if(scoreEarned >= 5000)
		{
			Tier5.text = "";
		}
	}
}
