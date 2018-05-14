using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableGenerationSystem : MonoBehaviour {


	public ObjectPoolDesignPatternSystem objectPool; //the object pool
	public float gapBetween; //the actually distance between the enemies 

	/*
	This function is used to place a collectable on the screen 
	*/
	public void placeCollectable(Vector3 startPlace)
	{
		//gapBetweenEnemies = Random.Range(minDistance,maxDistance); //get a random value between the min and max distances
		//transform.position = new Vector3(transform.position.x + enemyLength + gapBetweenEnemies, transform.position.y,0); //set the posiiton of the enemy
		GameObject collectableToAdd = objectPool.getNotActivePoolObject(); //get the platform from the object pool
		collectableToAdd.transform.position = startPlace; //set the position of the platform
		//enemyToAdd.transform.rotation = transform.rotation; //set the roation of the platform
		collectableToAdd.SetActive(true); //display the platf
	}
}
