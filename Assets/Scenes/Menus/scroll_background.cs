using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scroll_background : MonoBehaviour {

	public float speed;
	public  Renderer rend;

	//public GameObject HelpCanvas;

	//private CanvasComponent;
	// Use this for initialization
	void Start () {
		rend.GetComponent<Renderer>();

	}
	
	// Update is called once per frame
	void Update () {
		Vector2 offset = new Vector2 (Time.time * speed, 0);


		//GetComponent<Renderer>().material.mainTextureOffset = offset;﻿
		rend.material.mainTextureOffset = offset;
	}
	/*public void onClickHelp(){
		HelpCanvas.SetActive (true);
	}
	public void OnClickExitHelp(){
		HelpCanvas.SetActive (false);
	}*/
}
