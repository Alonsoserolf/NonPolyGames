using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Link : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void GoToLink(){
		Application.OpenURL("http://npgames.herokuapp.com");
	}
}
