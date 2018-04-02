using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class menuVertical : MonoBehaviour {
	public EventSystem eventSyst;
	public GameObject selectedObjct;
	public bool isLoadin;
	public bool buttonSelect;
	// Use this for initialization
	void Start () {
		
		buttonSelect = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxisRaw("Horizontal") != 0 && buttonSelect == false /*&& isPaused == true*/)
		{
			eventSyst.SetSelectedGameObject(selectedObjct);
			buttonSelect = true;
	
		}
	
	}
	private void OnDisable(){
		buttonSelect = false;
	}
}