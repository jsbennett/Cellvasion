using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1State : IState {

	private string nextState = "DeadLevel"; 
	

	public void Enter () {
		SceneManager.LoadScene("Level1", LoadSceneMode.Single); 
	}
	
	
	public string Exit () {
		return nextState; 
	}
}
