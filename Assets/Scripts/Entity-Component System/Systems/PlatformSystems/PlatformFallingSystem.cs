using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
This system is used to make the platform fall once a player lands on it 
Based on: https://unity3d.com/learn/tutorials/topics/2d-game-creation/creating-basic-platformer-game
*/
public class PlatformFallingSystem : MonoBehaviour {
    private StateMachineSystem stateMachine; //used to store the value for the stateMachine
    public float fallRate = 1f; //this is the 
    private Rigidbody2D platform;

    /*
    This function is used to get the rigidbody component of the platform 
    */
    void Start()
    {
        stateMachine = FindObjectOfType<StateMachineSystem>();
        platform = gameObject.GetComponent<Rigidbody2D>(); //get the rigiboody 
    }


    /*
    This functions is used to detect whether a collision has happened between the player and the platform 
    */
    void OnCollisionEnter2D (Collision2D itemCollided)
    {
         string getCurrentLevel = stateMachine.getCurrentLevel();
         if(getCurrentLevel == "Level5" || getCurrentLevel == "Level2")  
         { 
            if (itemCollided.gameObject.CompareTag("Player")) //if the object collided is the player then 
            {
                Invoke ("FallPlatform", fallRate); //make the platfrom fall
            }
        }
    }

    /*
    This funciton is used to make the platform no longer kinematic meaning it is affected by gravity and will fall 
    */
    void FallPlatform()
    {
            platform.isKinematic = false; //set the platforms kinematic setting to false
    }



}

