using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
This system is used to move the ghost enemy towards the player when the player is detected
Based and adapted from: https://www.youtube.com/watch?v=-yQjn9ekh5I
*/
public class EnemyFlyingSystem : MonoBehaviour {

	private bool movingRight = false; 
	public GameObject player; //a reference to the player 
	public float velocity; //how fast the enemy will move 
	public float detectionRange; //the range of how far a player can be detected from 
	public LayerMask playerLayer; //used to hold a referece to the player layer
	private bool playerDetected = false; //used to determine whether a player has been detected or not

	void Start()
	{
		player = GameObject.FindGameObjectWithTag("Player"); 
	}


	// Update is called once per frame
	void Update () {
		
		playerDetected = Physics2D.OverlapCircle(transform.position, detectionRange, playerLayer); //check if the player is within the circle - returns true if they are and false if they are not 
		if(playerDetected == true) //if the player is in the range of the enemy
		{	
			if(transform.position.x > 0 && movingRight) //if facing right and wanting to move left
			{
				changeDirection(); //change direction 
			}
			else if(transform.position.x < 0 && !movingRight) //if facing left and wanting to move right
			{
				changeDirection(); //change direction
			}
			
		transform.position = Vector3.MoveTowards(transform.position, player.transform.position, velocity*Time.deltaTime); //move the enemy towards the player - time.deltaTime is the time since the last frame was run
		}

	}

	/*
	This function is used to change the direction the player is moving in
	*/
	void changeDirection()
	{
		movingRight = !movingRight; //no longer right so set it to be the opposite; 
		Vector3 flipper = this.transform.localScale; //get the local scale so you can flip it 
		flipper.x = flipper.x * -1; //flip the local scale variable
		this.transform.localScale = flipper; //

	}
	/*
	This function is used to add the sphere to the enemy 
	*/
	void OnDrawGizmosSelected()
	{
		Gizmos.DrawSphere(transform.position, detectionRange); //add the sphere to the enemy 

	}
}
