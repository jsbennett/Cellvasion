using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialCollectablePickupSystem : MonoBehaviour {


	public string id; 

	private SpecialCollectableSaveSystem saveSystsem; 
	void Start () {
		saveSystsem = FindObjectOfType<SpecialCollectableSaveSystem>(); //find the collectable system 
	}
	
	void OnTriggerEnter2D(Collider2D collisionItem)
	{
		if(collisionItem.gameObject.name == "MainPlayer")
		{
			//add the collectable to the save system 
			gameObject.SetActive(false); 
		}
	}
}
