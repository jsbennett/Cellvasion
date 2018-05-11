using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeGeneratingSystem : MonoBehaviour {

	public ObjectPoolDesignPatternSystem objectPool; //the object pool
	public float gapBetweenTime; //the actually distance between the enemies 

	/*
	This function is used to place an time on the screen 
	*/
	public void placeCollectable(Vector3 startPlace)
	{
		GameObject collectableToAdd = objectPool.getNotActivePoolObject(); //get the platform from the object pool
		collectableToAdd.transform.position = startPlace; //set the position of the platform
		collectableToAdd.SetActive(true); //display the platf
	}
}
