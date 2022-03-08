using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler {

	private CanvasGroup kanvasGrupa;
	private RectTransform velkObjRectTransf;

	public Object objektuSkripts;

	// Use this for initialization
	void Start () {
		kanvasGrupa = GetComponent<CanvasGroup> ();
		velkObjRectTransf = GetComponent<RectTransform> ();
	}
	
	public void OnPointerDown(PointerEventData darbiba){
		Debug.Log ("Uzklikšķināts uz objekta");
	}
	public void OnBeginDrag(PointerEventData darbiba){
		Debug.Log ("Uzsākta objekta vilkšana");
		kanvasGrupa.alpha = 0.6f;
		kanvasGrupa.blocksRaycasts = false;
	}
	public void OnDrag(PointerEventData darbiba){
		Debug.Log ("Notiek objekta vilkšana");
		velkObjRectTransf.anchoredPosition += darbiba.delta / objektuSkripts.kanva.scaleFactor;
	}
	public void OnEndDrag(PointerEventData darbiba){
		Debug.Log ("Beigta objekta vilkšana");

	}
}
