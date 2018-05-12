using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level3State : IState {

	private string nextState = "Level2"; 
	

	public void Enter () {
		SceneManager.LoadScene("Level3", LoadSceneMode.Single); 
	}
	
	
	public string Exit () {
		return nextState; 
	}
}
