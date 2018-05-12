using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IState {

	
	void Enter(); //method used to carry out the loading of the level
	string Exit(); //method used when the state is changed to the next state 
}
