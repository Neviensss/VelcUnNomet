using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Taimeris : MonoBehaviour {
	public objektuSkripts objektuSkripts;
	void Update () {
		if (objektuSkripts.startetsTaimeris == true) {
			objektuSkripts.taimeris += Time.deltaTime;
		}
	}
}
