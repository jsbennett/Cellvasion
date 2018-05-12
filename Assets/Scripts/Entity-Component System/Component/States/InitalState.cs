using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InitalState : MonoBehaviour, IState {

	private string nextState = "Level4"; 
	

	public void Enter () {
		SceneManager.LoadScene("Level5", LoadSceneMode.Single); 
	}
	
	
	public string Exit () {
		return nextState; 
	}
}
