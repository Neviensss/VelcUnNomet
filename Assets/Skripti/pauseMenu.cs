using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour {
	void Update(){
	if(Input.GetKey (KeyCode.Escape)){
			SceneManager.LoadScene ("main menu", LoadSceneMode.Single);
	}
	}
	void PauseGame ()
	{
		Time.timeScale = 0;
	}
	void ResumeGame ()
	{
		Time.timeScale = 1;
	}
}
