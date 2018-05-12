using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButtonSystem : MonoBehaviour {

	private StateMachineSystem stateMachine; 
	// Use this for initialization
	void Start () {
		stateMachine = FindObjectOfType<StateMachineSystem>(); 
	}

	public void changeState()
	{
		stateMachine.change(); 
	}
}
