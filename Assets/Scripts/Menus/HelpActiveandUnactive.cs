﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelpActiveandUnactive : MonoBehaviour {

	public GameObject HelpCanvas;
	public Menu Menuld;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void onClickHelp(){
		if (!Menuld.isLoading) {
			Menuld.isLoading = false;
			HelpCanvas.SetActive (true);
		}
	}
	public void OnClickExitHelp(){
		if (!Menuld.isLoading) {
			Menuld.isLoading = false;
			Menuld.buttonSelected = false;
			HelpCanvas.SetActive (false);
		}
	}
}