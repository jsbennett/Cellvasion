using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class InfoPageSystem : MonoBehaviour {

	public void clickButton()
	{
		SceneManager.LoadScene("CreditsScene", LoadSceneMode.Single);
	}
}
