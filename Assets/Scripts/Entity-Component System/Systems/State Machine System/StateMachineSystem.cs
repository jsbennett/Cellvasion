using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachineSystem : MonoBehaviour {

	public Dictionary<string, IState> levelStates; // a dictionary used to store all the level states
	private static bool StateMachineAlreadyMade = false; //used to determine whether the state machine has been made or not 
	public IState currentState; 
	public string currentStateID; 
	
	/*
	Awake used so when the game is first made then an instance of this object is made and is told that it should not be destoryed
	*/
	void Awake()
    {
        if (StateMachineAlreadyMade == false) //if the statemachine has not already been made then 
        {
            DontDestroyOnLoad(this.gameObject); //do not destory this object between scenes
            StateMachineAlreadyMade = true; //set the machine to have been made 
            levelStates = new Dictionary<string, IState>(); //create the dictionary 
    	 	levelStates.Add("InitialState",new InitialState()); //set the intial state
    	 	levelStates.Add("Level5",new Level5State()); //add level 5
    	 	levelStates.Add("Level4",new Level4State()); //add level 4
    	 	levelStates.Add("Level3",new Level3State()); //add level 3
    	 	levelStates.Add("Level2",new Level2State()); //add level 2
    	 	levelStates.Add("Level1",new Level1State()); //add level 1
    	 	levelStates.Add("DeadLevel",new DeadLevelState()); //add dead level
    	 	InitialState inital = new InitialState(); 
    	 	currentState = inital; 
    	 	currentStateID = "InitialState"; 
        }
    }

    public void change()
    {
    	string stateToChange = currentState.Exit(); 
    	IState nextState = levelStates[stateToChange]; 
    	currentState = nextState; 
    	currentStateID = stateToChange; 
    	currentState.Enter(); 
    }
	
    public string getCurrentLevel()
    {
        return currentStateID; 
    }
	
}
