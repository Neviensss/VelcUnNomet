using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class objektuSkripts : MonoBehaviour {

	public Canvas kanva;
	public GameObject Atkritumi;
	public GameObject Ambulance;
	public GameObject Autobuss;
	public GameObject b2;
	public GameObject Cements;
	public GameObject e46;
	public GameObject ekskavators;
	public GameObject Policija;
	public GameObject TraktorsDzeltens;
	public GameObject TraktorsZals;
	public GameObject Ugunsdzesejs;
	public int punkti = 0;
	public float taimeris;
	public bool startetsTaimeris = false;
	public GameObject Uzvara;
	public GameObject Restarts;
	public GameObject Zvaigzne1;
	public GameObject Zvaigzne2;
	public GameObject Zvaigzne3;
	public Text laikaIzvade;

	[HideInInspector]
	public Vector2 atkrKord;
	[HideInInspector]
	public Vector2 ambKord;
	[HideInInspector]
	public Vector2 autKord;
	[HideInInspector]
	public Vector2 b2Kord;
	[HideInInspector]
	public Vector2 cemKord;
	[HideInInspector]
	public Vector2 e46Kord;
	[HideInInspector]
	public Vector2 eksKord;
	[HideInInspector]
	public Vector2 polKord;
	[HideInInspector]
	public Vector2 traktDzKord;
	[HideInInspector]
	public Vector2 traktZKord;
	[HideInInspector]
	public Vector2 UgunsKord;

	public AudioSource skanasAvots;
	public AudioClip[] skana;

	[HideInInspector]
	public bool vaiIstajaVieta = false;

	public GameObject pedejaisVilktais = null;

	void Start(){
		atkrKord = Atkritumi.GetComponent<RectTransform> ().localPosition;
		ambKord = Ambulance.GetComponent<RectTransform> ().localPosition;
		autKord = Autobuss.GetComponent<RectTransform> ().localPosition;
		b2Kord = b2.GetComponent<RectTransform> ().localPosition;
		cemKord = Cements.GetComponent<RectTransform> ().localPosition;
		e46Kord = e46.GetComponent<RectTransform> ().localPosition;
		eksKord = ekskavators.GetComponent<RectTransform> ().localPosition;
		polKord = Policija.GetComponent<RectTransform> ().localPosition;
		traktDzKord = TraktorsDzeltens.GetComponent<RectTransform> ().localPosition;
		traktZKord = TraktorsZals.GetComponent<RectTransform> ().localPosition;
		UgunsKord = Ugunsdzesejs.GetComponent<RectTransform> ().localPosition;
		startetsTaimeris = true;
		laikaIzvade.GetComponent<Text>().enabled = false;
		Uzvara.SetActive (false);
		Zvaigzne1.SetActive(false);
		Zvaigzne2.SetActive(false);
		Zvaigzne3.SetActive(false);
		Restarts.SetActive(false);
	}

}
