using UnityEngine.UI; //needed to be able to manipulate the text lables 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSystem : MonoBehaviour {

	public Text playerScore; 
	public Text timerLabel;  
	public float scoreEarned;
	public float pointsMultiplier;  
	public float timeRemaining = 30;
	public float numberOfPointsGiven; 
	private StateMachineSystem stateMachine; 
	
	// Use this for initialization
	void Start() {
		stateMachine = FindObjectOfType<StateMachineSystem>(); 
		if(stateMachine.getCurrentLevel() != "Level5")
		{
			scoreEarned = PlayerPrefs.GetFloat("scoreEarned"); 
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(timeRemaining <= 0)
		{
			stateMachine.change();  
		}

		//if(notDead == true)
		//{
			scoreEarned = scoreEarned + numberOfPointsGiven * pointsMultiplier * Time.deltaTime; //
			timeRemaining = timeRemaining - Time.deltaTime; 
		//}
		/*if(notDead == false)
		{
			PlayerPrefs.SetFloat("scoreEarned",scoreEarned); //save  the score 
		}*/
		playerScore.text = "Score: " + Mathf.Round(scoreEarned); //print the score out to the label 
		timerLabel.text = "Time Remaining: " + Mathf.Round(timeRemaining); //print the amount of time remaining
		PlayerPrefs.SetFloat("scoreEarned",scoreEarned); //save  the score 
	}

	public void IncreaseScore(int valueToAdd)
	{
		scoreEarned = scoreEarned + valueToAdd;
	}

	public void IncreaseTime(int valueToAdd)
	{
		timeRemaining = timeRemaining + valueToAdd;
	}

}
