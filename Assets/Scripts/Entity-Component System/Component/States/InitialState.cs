using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InitialState : IState {

	private string nextState = "Level5"; 
	

	public void Enter () {
		SceneManager.LoadScene("MainMenu", LoadSceneMode.Single); 
	}
	
	
	public string Exit () {
		return nextState; 
	}
}
