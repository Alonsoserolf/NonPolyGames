using System.Collections;
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
		//StartCoroutine (LoadingLevelClickHelp());
		if (!Menuld.isLoading) {
			Menuld.isLoading = false;
			HelpCanvas.SetActive (true);
		}
	}
	/*IEnumerator LoadingLevelClickHelp(){
		yield return new WaitForSeconds(1f);
		if (!Menuld.isLoading) {
			Menuld.isLoading = false;
			HelpCanvas.SetActive (true);
		}
	}*/
	public void OnClickExitHelp(){
		//StartCoroutine (LoadingLevelQuitHelp());
		if (!Menuld.isLoading) {
			Menuld.isLoading = false;
			Menuld.buttonSelected = false;
			HelpCanvas.SetActive (false);
		}
	}
	/*IEnumerator LoadingLevelQuitHelp(){
		yield return new WaitForSeconds(1f);
		if (!Menuld.isLoading) {
			Menuld.isLoading = false;
			Menuld.buttonSelected = false;
			HelpCanvas.SetActive (false);
		}
	}*/
}
