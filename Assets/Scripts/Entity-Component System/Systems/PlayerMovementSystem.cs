using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
PlayerMovementSystem - this system is used to move the player about the scene and to display the animation
Based and adapted from: https://unity3d.com/learn/tutorials/topics/2d-game-creation/2d-character-controllers?playlist=17093
*/
public class PlayerMovementSystem : MonoBehaviour {
	
	public float playerMaximumVelocity = 15f; //used to determine how fast the player should move 
	public float movementValue; //used to store the value of the player on the horizontal axis 
	
	public float forceForJump = 1000f; //the force to be applied to the player when jumping 
	public bool isJumping = false; //used to determin whehter the character is jumping or not
	public bool jumpInAir = false; //this is to keep track of the number of jumps the player has done to be able to determine whehter they can double jump 
	
	public Transform groundChecking; //used to check if the player is standing on the platforms or not 
	private bool onGround = false; //used to determin whether the player is actual on the ground or not 
	public float radius = 0.2f; //this is the radius to check the ground 
	public LayerMask ground; //this is a layer to identidy the ground 

	private Animator animator; //animator object to be able to run the animations of the player
	private Rigidbody2D playerBody; //used to store the rigid body component of the player 
	

	/*
	Start - is used to set up when the script is initalised 
	*/
	void Start()
	{
		animator = gameObject.GetComponent<Animator>(); //used to get the animator of the player 
		playerBody = gameObject.GetComponent<Rigidbody2D>(); //get the rigid body component of the player 
	}

	//Update is called once per frame 
	void Update()
	{
		player_Jump();
	}

	//fixed update is used for updating in time with physics
	void FixedUpdate () {
		move_Player(); //call the method to move the player 
	}

	/*
	This function is used to control the movement of the player
	*/
	void move_Player() {
		checkForGround(); //check to see if the player us on the ground 
		movementValue = Input.GetAxis("Horizontal"); //get the value of how much the player is moving on the horizontal axis
		animations(movementValue); //display the animations 
		playerBody.velocity = new Vector2(movementValue * playerMaximumVelocity, playerBody.velocity.y);  //move the player 
	}

	/*
	This function is used to check if the player is on the ground 
	*/
	void checkForGround()
	{
		onGround = Physics2D.OverlapCircle(groundChecking.position, radius, ground); //used to check if there are any collisions within the circle at the players feet 
		animator.SetBool("Ground", onGround); //this is used to check over and over again if the player is on the ground - returns true if on the ground and false if not 
		animator.SetFloat("VerticalSpeed", playerBody.velocity.y); //used to get the vertical speed of the player so they can jump  

	}

	/*
	This function is used to control the animation of the player
	*/
	void animations(float movementValue)
	{
		animator.SetFloat("Speed", Mathf.Abs(movementValue)); //only uses postive numbers (absolute) to set the speed whether goinf left or right
	}

	/*
	This function is used to control the jump of the player 
	*/
	void player_Jump()
	{
		if((onGround == true || jumpInAir == false) && Input.GetKeyDown(KeyCode.Space)) //if on the ground then can jump
		{
			animator.SetBool("Ground", false); //set the boolean for being on the ground to false 
			playerBody.velocity = new Vector2(playerBody.velocity.x,0); //get the velocity of the player and take away the y velocity to add the force of jump 
			playerBody.AddForce(new Vector2(0, forceForJump)); //add the force of jump 
			jumpInAir = false;  //since they have not jumped in the air then make sure its false

			if(onGround == false) //if they are not on the ground and have made a jump then 
			{
				jumpInAir = true; //they have jumped in the air so can no longer jump again 
			}
		}


	}
}
