using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayLevel : MonoBehaviour {
	private StateMachineSystem stateMachine; 
	// Use this for initialization
	void Start () {
		stateMachine = FindObjectOfType<StateMachineSystem>(); 
		if(stateMachine.getCurrentLevel() == "Level5")
		{
			UpdateLabel(5);  
		}
		else if(stateMachine.getCurrentLevel() == "Level4")
		{

		}
		else if(stateMachine.getCurrentLevel() == "Level4")
		{
			
		}
		else if(stateMachine.getCurrentLevel() == "Level4")
		{
			
		}
		else 
		{

		}
		
	}

	void UpdateLabel(int LevelNumber)
	{
		//levelLabel.text = "Level: " + LevelNumber; //print the amount of time remaining
	}
	
}
