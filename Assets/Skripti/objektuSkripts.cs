using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objektuSkripts : MonoBehaviour {

	public Canvas kanva;
	public GameObject Atkritumi;
	public GameObject Ambulance;
	public GameObject Autobuss;

	[HideInInspector]
	public Vector2 atkrKord;
	[HideInInspector]
	public Vector2 ambKord;
	[HideInInspector]
	public Vector2 autKord;

	public AudioSource skanasAvots;
	public AudioClip[] skana;

	[HideInInspector]
	public bool vaiIstajaVieta = false;

	public GameObject pedejaisVilktais = null;

	void Start(){
		atkrKord = Atkritumi.GetComponent<RectTransform> ().localPosition;
		ambKord = Ambulance.GetComponent<RectTransform> ().localPosition;
		autKord = Autobuss.GetComponent<RectTransform> ().localPosition;
	}
}
