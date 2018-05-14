using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UnlockableButtonSystem : MonoBehaviour {

	public void moveToUnlockables()
	{
		SceneManager.LoadScene("InfoScene", LoadSceneMode.Single); 
	}
	
}
