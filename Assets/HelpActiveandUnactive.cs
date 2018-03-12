using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpActiveandUnactive : MonoBehaviour {

	public GameObject HelpCanvas;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void onClickHelp(){
		HelpCanvas.SetActive (true);
	}
	public void OnClickExitHelp(){
		HelpCanvas.SetActive (false);
	}
}
