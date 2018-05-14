using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
based and adapted from https://unity3d.com/learn/tutorials/projects/2d-ufo-tutorial/following-player-camera
*/ 
public class CameraSystem : MonoBehaviour {

	public GameObject playerObject; //a reference of the player 
	private Vector3 cameraDistance; //Used to store the distance between the player and the camera - the camera still uses x,y,z hence using vector 3 
	
	void Start () {
		cameraDistance = transform.position - playerObject.transform.position; //get the position of the camera from the player 
	}
	
	//LateUpdate is used just after update has run  
	void LateUpdate () {
		transform.position = playerObject.transform.position + cameraDistance; //set the camera position to be where the player was plus the postion of the camera from the player
	}
}
