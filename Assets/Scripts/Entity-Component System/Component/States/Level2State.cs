using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2State : IState {

	private string nextState = "Level1"; 
	

	public void Enter () {
		SceneManager.LoadScene("Level2", LoadSceneMode.Single); 
	}
	
	
	public string Exit () {
		return nextState; 
	}
}
