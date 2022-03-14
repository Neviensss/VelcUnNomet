using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjektuTransformacija : MonoBehaviour {

	private float lielumsx, lielumsy, rotz;
	public objektuSkripts objektuSkriptss;

	void Update(){
		if(objektuSkriptss.pedejaisVilktais !=null){
		if (Input.GetKey (KeyCode.Z)) {
				objektuSkriptss.pedejaisVilktais.GetComponent<RectTransform> ().Rotate(0,0,Time.deltaTime  *9f);
			}
			if(Input.GetKey (KeyCode.X)){
				objektuSkriptss.pedejaisVilktais.GetComponent<RectTransform> ().Rotate(0,0,-Time.deltaTime  *9f);
			}

			if (Input.GetKey (KeyCode.UpArrow)) {
				if (objektuSkriptss.pedejaisVilktais.GetComponent<RectTransform> ().localScale.y <= 0.8f) {
					objektuSkriptss.pedejaisVilktais.GetComponent<RectTransform> ().localScale 
					= new Vector2 (objektuSkriptss.pedejaisVilktais.GetComponent<RectTransform>().localScale.x +0.001f,
						objektuSkriptss.pedejaisVilktais.GetComponent<RectTransform>().localScale.y +0.001f);
				}
			}
			if (Input.GetKey (KeyCode.DownArrow)) {
				if (objektuSkriptss.pedejaisVilktais.GetComponent<RectTransform> ().localScale.y >= 0.5f) {
					objektuSkriptss.pedejaisVilktais.GetComponent<RectTransform> ().localScale 
					= new Vector2 (objektuSkriptss.pedejaisVilktais.GetComponent<RectTransform> ().localScale.x - 0.001f,
						objektuSkriptss.pedejaisVilktais.GetComponent<RectTransform> ().localScale.y - 0.001f);
				}
			}
			if (Input.GetKey (KeyCode.RightArrow)) {
				if (objektuSkriptss.pedejaisVilktais.GetComponent<RectTransform> ().localScale.y <= 0.8f) {
					objektuSkriptss.pedejaisVilktais.GetComponent<RectTransform> ().localScale 
					= new Vector2 (objektuSkriptss.pedejaisVilktais.GetComponent<RectTransform> ().localScale.x + 0.001f,
						objektuSkriptss.pedejaisVilktais.GetComponent<RectTransform> ().localScale.y);
				}
			}
			if(Input.GetKey (KeyCode.LeftArrow)){
				if (objektuSkriptss.pedejaisVilktais.GetComponent<RectTransform> ().localScale.y >= 0.4f) {
					objektuSkriptss.pedejaisVilktais.GetComponent<RectTransform> ().localScale 
					= new Vector2 (objektuSkriptss.pedejaisVilktais.GetComponent<RectTransform> ().localScale.x - 0.001f,
						objektuSkriptss.pedejaisVilktais.GetComponent<RectTransform> ().localScale.y);
				}
			}
		}
	}
}

