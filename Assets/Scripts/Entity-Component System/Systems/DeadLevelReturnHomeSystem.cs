using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class DeadLevelReturnHomeSystem : MonoBehaviour {

	private StateMachineSystem stateMachine; 
	
	void Start()
	{
		stateMachine = FindObjectOfType<StateMachineSystem>();
	}
	public void change()
	{ 
		stateMachine.change(); 
		//SceneManager.LoadScene(0, LoadSceneMode.Single); 
	}
}
