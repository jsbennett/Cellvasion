using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
This system is used to make sure that the player sweeper stays constant alng the y axis
based and adapted from https://unity3d.com/learn/tutorials/topics/scripting/lets-make-game-infinite-runner
*/
public class PlayerSweeperCameraSystem : MonoBehaviour {
	
	public Transform playerObject; 
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(playerObject.position.x, -20, 0); //keep the player sweeper moving at at the pace of the player but never moving down with the player when they fall 
	}
}
