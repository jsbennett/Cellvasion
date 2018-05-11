using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
This system is used to generate platfroms to be placed on the level 
based and adapted from https://www.youtube.com/watch?v=YznQRjbIpLU&t=2s
and https://www.youtube.com/watch?v=DCncsRU045M&t=120s
*/
public class PlatfromGenerationSystem : MonoBehaviour {
	
	public Transform pointforGeneration; //this is used t store the point at which the platform should be generated from
	public float maxDistance; //this is the maximum distance that platforms can be generated to 
	public Transform maximumHeightPlacement; //this is used to determine the maximum height  platfrom can be placed 
	private float maximumHeight; //this stored the maximum height 
	private float[] platformLength; //this array is used to store all the platforms of different lengths 
	public ObjectPoolDesignPatternSystem[] objectPool; //this is an array of object pools for the different platforms
	public float minimumHeight; //this stores the minimum height
	public float minDistance; //this is used as the minimum distance that platforms can be generated to 
	public float gapBetweenPlatforms; //this is the space that should be between the platforms 
	public float gapHeight; //this is used to determine the gap between the patforms height 
	private float heightDistance; //this is the distance between the heights 
	private int platformNumber;  //this is used to store the random number generated to pick a random platform
	private CollectableGenerationSystem collectablePool; // a reference to the collectable pool
	public float numberOfCollectables; //this is used to determine whether the collectable will be generated on a platform
	private TimeGeneratingSystem timePool; //used to reference the time pool
	/*
	this Function is used to set up variables used to place the platforms 
	*/
	void Start()
	{
		timePool = FindObjectOfType<TimeGeneratingSystem>(); 
		collectablePool = FindObjectOfType<CollectableGenerationSystem>(); //find the collectable generator
		platformLength = new float[objectPool.Length];  //create the platform length array to be the length of the object pool
		fillPlatformArray(); //fill the object pool array with platforms 
		maximumHeight = maximumHeightPlacement.position.y; //set the maximum height to be the y value of the place holder 
	}

	/*
	update which runs at every frame is used to place the platforms 
	*/
	void Update()
	{
		if(transform.position.x < pointforGeneration.position.x) //if the players location is less than the point for generation then 
		{
			
			placePlatforms(); //place the platform on the game
		}
	}

	/*
	This function is used to fill the platform length array 
	*/
	void fillPlatformArray()
	{
		for(int i = 0; i < objectPool.Length; i++) //for each item in the object pool
		{
			platformLength[i] = objectPool[i].objectPoolObject.GetComponent<BoxCollider2D>().size.x; //get the size of the platform and store it in the platform length array 
		}
	}

	/*
	This function is used to place the platforms on the scene 
	*/
	void placePlatforms()
	{
		//for loop is used to place multiple platforms at the same time 
		for (int i = 0; i < 20; i++)
		{
			gapBetweenPlatforms = Random.Range(minDistance,maxDistance); //set the gap between the platforms to be a random value between the minimum and maximum platfrom distance 
			platformNumber = Random.Range(0,objectPool.Length); //generate a random number from the values in the object pool array and set that to be the paltform to be displayed 
			heightDistance = transform.position.y + Random.Range(gapHeight, - gapHeight); //select a random heigh for the platform to be placed at 
			if(heightDistance > maximumHeight) //if the random number produced is more than the maximum height allowed then 
			{
				heightDistance = maximumHeight; //set the platform to be at the maximum height 
			}
			else if(heightDistance < minimumHeight) //if the random number produced is less than the minimum height allowed then 
			{
				heightDistance = minimumHeight; //set the height to be the minimum height
			}
			transform.position = new Vector3(transform.position.x + platformLength[platformNumber] + gapBetweenPlatforms,heightDistance,0); //set the position to be these values produced 
			
			GameObject platformToAdd = objectPool[platformNumber].getNotActivePoolObject(); //get the platform from the object pool
			platformToAdd.transform.position = transform.position; //set the position of the platform
			platformToAdd.transform.rotation = transform.rotation; //set the roation of the platform
			platformToAdd.SetActive(true); //display the platform on the game 

			if(Random.Range(0f,10f) < numberOfCollectables) //if the random number generated is less then the number allowed then 
			{
				collectablePool.placeCollectable(new Vector3(transform.position.x, transform.position.y + 3,0)); //add the collectable to the platform 
			}

			if(Random.Range(0f,15f) < numberOfCollectables) //if the random number generated is less then the number allowed then 
			{
				timePool.placeCollectable(new Vector3(transform.position.x -2, transform.position.y + 3,0)); 

			}
		}

	}

}
