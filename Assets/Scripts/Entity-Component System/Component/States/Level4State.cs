using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level4State : IState {

	private string nextState = "Level3"; 
	

	public void Enter () {
		SceneManager.LoadScene("Level4", LoadSceneMode.Single); 
	}
	
	
	public string Exit () {
		return nextState; 
	}
}
