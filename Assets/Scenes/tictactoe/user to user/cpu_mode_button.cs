﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class cpu_mode_button : MonoBehaviour {

    public void second_screen()
    {
		StartCoroutine (LoadingLevelCpuVsUser ());
        /*tictac_cpu_mode.mode_choice = 0;
        SceneManager.LoadScene("cpu vs user");*/
  
       
    }
	IEnumerator LoadingLevelCpuVsUser(){
		yield return new WaitForSeconds(1f);
		tictac_cpu_mode.mode_choice = 0;
		SceneManager.LoadScene("cpu vs user");
	}
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
