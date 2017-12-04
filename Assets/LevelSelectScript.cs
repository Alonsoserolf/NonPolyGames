﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectScript : MonoBehaviour {

	private int worldIndex;   
	private int levelIndex;   

	void  Start (){
		//loop thorugh all the worlds
		for(int i = 1; i <= LockLevel.worlds; i++)
		{
			//if(Application.loadedLevelName == "World"+i)old version
			if (SceneManager.GetActiveScene().name == "World"+i)
			{
				Debug.Log ("In getactivescene if statement worldindex:"+ i);
				worldIndex = i;
				CheckLockedLevels(); 
			}
		}
	}

	//Level to load on button click. Will be used for Level button click event 
	public void Selectlevel(string worldLevel){
		//Application.LoadLevel("Level"+worldLevel); //load the level
		SceneManager.LoadScene("Level"+worldLevel);
	}

	//uncomment the below code if you have a main menu scene to navigate to it on clicking escape when in World1 scene
	/*public void  Update (){
  if (Input.GetKeyDown(KeyCode.Escape) ){
   Application.LoadLevel("MainMenu");
  }   
 }*/

	//function to check for the levels locked
	void  CheckLockedLevels ()
	{
		//loop through the levels of a particular world
		for(int j = 1; j < LockLevel.levels; j++)
		{
			Debug.Log ("incheckforloop");
			levelIndex = (j+1);
			Debug.Log ("worldIndex: "+worldIndex+" levelINdex "+levelIndex);
			Debug.Log ("playerPref: "+ PlayerPrefs.GetInt("level"+worldIndex.ToString() +":" +levelIndex.ToString()));
			if((PlayerPrefs.GetInt("level"+worldIndex.ToString() +":" +levelIndex.ToString()))==1)
			{
				Debug.Log ("in playerPref get int worldIndex: "+worldIndex+" levelIndex "+levelIndex);
				//GameObject.Find("LockedLevel"+(j+1)).active = false;
				GameObject.Find("LockedLevel"+(j+1)).SetActive(false);
				Debug.Log ("Unlocked");
			}
		}

	}
}
