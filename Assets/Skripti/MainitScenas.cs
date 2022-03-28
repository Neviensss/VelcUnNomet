using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainitScenas : MonoBehaviour {
	public objektuSkripts objektuSkripts;
	public void UzSpeli(){
		SceneManager.LoadScene ("Sakums", LoadSceneMode.Single);
	}

	public void Restart()
    {
		SceneManager.LoadScene("Sakums", LoadSceneMode.Single);
	}

	void Update()
	{
		if (Input.GetKey(KeyCode.Escape))
		{
			Application.Quit();
		}
	}
	void PauseGame()
	{
		Time.timeScale = 0;
	}
	void ResumeGame()
	{
		Time.timeScale = 1;
	}

}
