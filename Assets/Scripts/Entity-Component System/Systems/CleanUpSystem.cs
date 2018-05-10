using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleanUpSystem : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D objectCollided)
	{
		if(objectCollided.tag == "Player")
		{
			Debug.Break(); 
			return; 
		}

		
		objectCollided.gameObject.SetActive(false); 
		/*if(other.gameObject.transform.parent) //if it has a parent destroy it
		{
			//Destroy(other.gameObject.transform.parent.gameObject);
			other.gameObject.transform.parent.SetActive(false); 
		}
		else
		{
			//Destroy(other.gameObject); 
			other.gameObject.SetActive(false);
		}*/
	}
}
