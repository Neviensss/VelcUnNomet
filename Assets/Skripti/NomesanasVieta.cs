using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class NomesanasVieta : MonoBehaviour, IDropHandler {

	private float vietasZrot, velkObjZrot, rotStarp;
	private Vector2 vietasIzm, velkObjIzm;
	private float xIzmStarp, yIzmStarp;

	public objektuSkripts objektuSkripts;

	public void OnDrop(PointerEventData notikums){
	
		if (notikums.pointerDrag != null) {
			if (notikums.pointerDrag.tag.Equals (tag)) {
				vietasZrot = notikums.pointerDrag.GetComponent<RectTransform> ().eulerAngles.z;
				velkObjZrot = GetComponent<RectTransform> ().eulerAngles.z;
				rotStarp = Mathf.Abs (vietasZrot - velkObjZrot);
				vietasIzm = notikums.pointerDrag.GetComponent<RectTransform> ().localScale;
				velkObjIzm = GetComponent<RectTransform> ().localScale;
				xIzmStarp = Mathf.Abs (vietasIzm.x - velkObjIzm.x);
				yIzmStarp = Mathf.Abs (vietasIzm.y - velkObjIzm.y);

				if ((rotStarp <= 6 || (rotStarp >= 354 && rotStarp <= 360)) && (xIzmStarp <= 0.1 && yIzmStarp <= 0.1)) {
					objektuSkripts.vaiIstajaVieta = true;

					notikums.pointerDrag.GetComponent<RectTransform> ().anchoredPosition = GetComponent<RectTransform> ().anchoredPosition;

					notikums.pointerDrag.GetComponent<RectTransform> ().localRotation = GetComponent<RectTransform> ().localRotation;

					notikums.pointerDrag.GetComponent<RectTransform> ().localScale = GetComponent<RectTransform> ().localScale;

					switch (notikums.pointerDrag.tag) {
					case "Atkritumi":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skana [1]);
						objektuSkripts.punkti++;
						break;
					case "Ambulance":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skana [2]);
						objektuSkripts.punkti++;
						break;
					case "Autobuss":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skana [3]);
						objektuSkripts.punkti++;
						break;
					case "b2":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skana [4]);
						objektuSkripts.punkti++;
						break;
					case "cements":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skana [5]);
						objektuSkripts.punkti++;
						break;
					case "e46":
						objektuSkripts.punkti++;
						break;
					case "ekskavators":
						objektuSkripts.punkti++;
						break;
					case "policija":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skana [6]);
						objektuSkripts.punkti++;
						break;
					case "traktorsDzeltens":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skana [7]);
						objektuSkripts.punkti++;
						break;
					case "traktorsZals":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skana [8]);
						objektuSkripts.punkti++;
						break;
					case "Ugunsdzesejs":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skana [9]);
						objektuSkripts.punkti++;
						break;

					default:
						Debug.Log ("Nederīgs Tags");
						break;
					}
				}
			} else {
				objektuSkripts.vaiIstajaVieta = false;
				objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skana[0]);

				switch(notikums.pointerDrag.tag){
				case "Atkritumi":
					objektuSkripts.Atkritumi.GetComponent<RectTransform> ().localPosition = objektuSkripts.atkrKord;
					break;
				case "Ambulance":
					objektuSkripts.Ambulance.GetComponent<RectTransform> ().localPosition = objektuSkripts.ambKord;
					break;
				case "Autobuss":
					objektuSkripts.Autobuss.GetComponent<RectTransform> ().localPosition = objektuSkripts.autKord;
					break;
				case "b2":
					objektuSkripts.b2.GetComponent<RectTransform> ().localPosition = objektuSkripts.b2Kord;
					break;
				case "cements":
					objektuSkripts.Cements.GetComponent<RectTransform> ().localPosition = objektuSkripts.cemKord;
					break;
				case "e46":
					objektuSkripts.e46.GetComponent<RectTransform> ().localPosition = objektuSkripts.e46Kord;
					break;
				case "Ekskavators":
					objektuSkripts.ekskavators.GetComponent<RectTransform> ().localPosition = objektuSkripts.eksKord;
					break;
				case "policija":
					objektuSkripts.Policija.GetComponent<RectTransform> ().localPosition = objektuSkripts.polKord;
					break;
				case "traktorsDzeltens":
					objektuSkripts.TraktorsDzeltens.GetComponent<RectTransform> ().localPosition = objektuSkripts.traktDzKord;
					break;
				case "traktorsZals":
					objektuSkripts.TraktorsZals.GetComponent<RectTransform> ().localPosition = objektuSkripts.traktZKord;
					break;
				case "Ugunsdzesejs":
					objektuSkripts.Ugunsdzesejs.GetComponent<RectTransform> ().localPosition = objektuSkripts.UgunsKord;
					break;
				default:
					Debug.Log ("Nederīgs Tags");
					break;
				}

			}
		}
	}

	public void NoteiktZvaigznes(){
		if (objektuSkripts.punkti == 11) {
			objektuSkripts.Uzvara.SetActive (true);

			if(objektuSkripts.taimeris <= 90f){

			}else if(objektuSkripts.taimeris <= 120f){

			}else if(objektuSkripts.taimeris <= 150f){
			
			}
		}
}
}