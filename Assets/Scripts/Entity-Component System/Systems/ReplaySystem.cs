using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ReplaySystem : MonoBehaviour {

	public void StartAgain()
	{
		SceneManager.LoadScene("Level5", LoadSceneMode.Single); 
	}
}
