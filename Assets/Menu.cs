﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	// Use this for initialization
	//public Scene MenuScene;

	void Start () {
		//SceneManager.LoadScene ("MainMenu",LoadSceneMode.Additive);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	/*public void OnGameMenu(){
		SceneManager.LoadScene(MenuScene);
	}*/
	public void OnInstantInsanity(){
		SceneManager.LoadScene ("InstantInsanityMenu");
	}
	public void OnToTicTacToe(){
		SceneManager.LoadScene ("TicTacToeMenu");
	}
	public void OnToSokaban(){
		SceneManager.LoadScene ("SokabanMenu");
	}
	public void OnBlock(){
		SceneManager.LoadScene ("BlockMenu");
	}
	public void OnReturntoMainMenu(){
		SceneManager.LoadScene ("MainMenu");
	}
	public void OnLevelSelect(){
		SceneManager.LoadScene ("SokabanLevelSelect");
	}
	public void OnTicPlay(){
		SceneManager.LoadScene ("TicTacToeUserComputer");
	}
	public void OnQuit(){
		#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#else
		Application.Quit();
		#endif
	}
}
