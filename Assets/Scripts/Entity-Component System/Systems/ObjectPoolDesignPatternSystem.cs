using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
This is an object pool to be able to reuse the plafroms produced 
based on and adapted from: https://unity3d.com/learn/tutorials/topics/scripting/object-pooling
*/
public class ObjectPoolDesignPatternSystem : MonoBehaviour {

	public GameObject objectPoolObject; //the object to be stored in the pool
	public bool increasePool = true; //used to determine whether the object pool can be increased or not 
	public int numberOfItemsToBePooled; //the  number to determine the number of items to be put in the object pool
	
	private List<GameObject> objectPool; //the pool to store objects 
	
	// Use this for initialization
	void Start () {

		objectPool = new List<GameObject>(); //create the pool list 

		//fill the  object pool with the items ot be added 
		for(int i =0; i <numberOfItemsToBePooled; i++)
		{ 
			createObjectForPool(); 
		}
	}

	/*
	This function is used to iterate through the object pool for not active items 
	*/
	public GameObject getNotActivePoolObject()
	{
		//loop through the game pool to see if there is an element which is not active 
		for(int i = 0; i < objectPool.Count; i++)
		{
			if(!objectPool[i].activeInHierarchy) //if the object is not active 
			{
				return objectPool[i]; //return the object from the pool
			}
		}
			
		//if there are no objects left to use then make more 
		if(increasePool == true)
		{
			GameObject tempObject = createObjectForPool(); //create an object 
			return tempObject; //return that platform 
		}
		return null; 
	}

	/*
	This function is used to create an object in the object pool  
	*/
	public GameObject createObjectForPool()
	{
		GameObject tempObject = Instantiate(objectPoolObject); //get the object to be added 
		tempObject.SetActive(false); //make it not active so its not displayed in the game 			
		objectPool.Add(tempObject); //add the object to the object pool 
		return tempObject; 
	}
}
