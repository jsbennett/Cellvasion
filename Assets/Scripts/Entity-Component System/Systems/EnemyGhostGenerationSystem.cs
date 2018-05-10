using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
This system is used to use the object pool to store for the enemy generation
*/
public class EnemyGhostGenerationSystem : MonoBehaviour {

	public ObjectPoolDesignPatternSystem objectPool; //the object pool
	public Transform pointForGeneration; //the point where the enemies should spawn
	public float minDistance; //the minimum distance between enemies 
	public float maxDistance; //the maximum distance between enemies 
	public GameObject enemy; //the game object of the enemy to be produced in the object pool
	public float gapBetweenEnemies; //the actually distance between the enemies 
	private float enemyLength; //the length of the eneies 
	// Use this for initialization
	void Start () {
		enemyLength = enemy.GetComponent<BoxCollider2D>().size.x; 
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.x < pointForGeneration.position.x) //if the players location is less than the point for generation then 
		{
			
			placeEnemy(); //place the enemy
		}
	}

	/*
	This function is used to place an enemy on the screen 
	*/
	void placeEnemy()
	{
		gapBetweenEnemies = Random.Range(minDistance,maxDistance); //get a random value between the min and max distances
		transform.position = new Vector3(transform.position.x + enemyLength + gapBetweenEnemies, transform.position.y,0); //set the posiiton of the enemy
		GameObject enemyToAdd = objectPool.getNotActivePoolObject(); //get the platform from the object pool
		enemyToAdd.transform.position = transform.position; //set the position of the platform
		enemyToAdd.transform.rotation = transform.rotation; //set the roation of the platform
		enemyToAdd.SetActive(true); //display the platf
	}
}
