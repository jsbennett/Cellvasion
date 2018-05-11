using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGhostPlayerCollisionSystem : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D objectCollided)
	{
		if(objectCollided.tag == "Player")
		{
			Destroy(objectCollided.gameObject);
			Application.Quit(); 
		}
	}
}
