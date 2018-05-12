using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnMainMenuSystem : MonoBehaviour {

	public void ReturnHome()
	{
		SceneManager.LoadScene("MainMenu", LoadSceneMode.Single); 
	}
}
