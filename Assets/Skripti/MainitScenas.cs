using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainitScenas : MonoBehaviour {
	public objektuSkripts objektuSkripts;
	public void UzSpeli(){
		SceneManager.LoadScene ("Sakums", LoadSceneMode.Single);
		objektuSkripts.startetsTaimeris = true;
	}
		
}
