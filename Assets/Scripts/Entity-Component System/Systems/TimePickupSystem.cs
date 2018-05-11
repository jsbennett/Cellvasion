using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimePickupSystem : MonoBehaviour {

	public int timeMultiplier; //the amount the colectable gives to the players score 

	private ScoreSystem scoreSystem; 

	// Use this for initialization
	void Start () {
		scoreSystem = FindObjectOfType<ScoreSystem>(); //find the system for the score 
	}
	
	void OnTriggerEnter2D(Collider2D collisionItem)
	{
		if(collisionItem.gameObject.name == "MainPlayer")
		{
			scoreSystem.IncreaseTime(timeMultiplier); 
			gameObject.SetActive(false); 
		}
	}
}
