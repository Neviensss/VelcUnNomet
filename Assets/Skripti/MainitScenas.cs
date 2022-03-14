using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainitScenas : MonoBehaviour {

	private float sekundes;
	private int zvaigznes = 0;

	public void UzSpeli(){
		SceneManager.LoadScene ("Sakums", LoadSceneMode.Single);
		sekundes += Time.deltaTime;
		if(sekundes >= 90){
			zvaigznes = 3;
		}else if(sekundes >= 130){
			zvaigznes = 2;
		}else if(sekundes >= 150){
			zvaigznes = 1;
	}
}
