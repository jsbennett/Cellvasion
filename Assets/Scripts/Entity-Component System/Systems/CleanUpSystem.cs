using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleanUpSystem : MonoBehaviour {

	private StateMachineSystem stateMachine; 
	// Use this for initialization
	void Start() {
		stateMachine = FindObjectOfType<StateMachineSystem>(); 
	}


	void OnTriggerEnter2D(Collider2D objectCollided)
	{
		if(objectCollided.tag == "Player")
		{
			stateMachine.change(); 
		}
		objectCollided.gameObject.SetActive(false); 
	}
}
