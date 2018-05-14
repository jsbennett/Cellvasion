using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadLevelState : IState {

	private string nextState = "InitialState"; 
	

	public void Enter () {
		SceneManager.LoadScene("DeadLevel", LoadSceneMode.Single); 
	}
	
	
	public string Exit () {
		return nextState; 
	}
}
