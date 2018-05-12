using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class InstructionsContinueSystem : MonoBehaviour {

	public void loadIntroduction()
	{
		SceneManager.LoadScene("StoryIntro", LoadSceneMode.Single); 
	}
}
