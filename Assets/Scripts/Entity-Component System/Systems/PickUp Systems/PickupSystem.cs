using UnityEngine.UI; 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Based on:https://www.youtube.com/watch?v=FaX4B_FMPIg 
*/
public class PickupSystem : MonoBehaviour {

	public int scoreMultiplier; //the amount the colectable gives to the players score 

	private ScoreSystem scoreSystem; 

	// Use this for initialization
	void Start () {
		scoreSystem = FindObjectOfType<ScoreSystem>(); //find the system for the score 
	}
	
	void OnTriggerEnter2D(Collider2D collisionItem)
	{
		if(collisionItem.gameObject.name == "MainPlayer")
		{
			scoreSystem.IncreaseScore(scoreMultiplier); 
			gameObject.SetActive(false); 
		}
	}
	
}
