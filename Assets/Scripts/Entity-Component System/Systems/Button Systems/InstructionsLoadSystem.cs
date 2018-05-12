using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class InstructionsLoadSystem : MonoBehaviour {

	public void loadInstructions()
	{
		SceneManager.LoadScene("Instructions", LoadSceneMode.Single); 
	}
}
