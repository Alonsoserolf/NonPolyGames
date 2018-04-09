using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Menu : MonoBehaviour {

	public EventSystem eventSystem;
	public GameObject selectedObject;
	public bool isLoading;
	public bool buttonSelected;
	// Use this for initialization
	//public Scene MenuScene;

	void Start () {
		//SceneManager.LoadScene ("MainMenu",LoadSceneMode.Additive);
		buttonSelected = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxisRaw("Vertical") != 0 && buttonSelected == false /*&& isPaused == true*/)
		{
			eventSystem.SetSelectedGameObject(selectedObject);
			buttonSelected = true;
		}
		
	}
	/*public void OnGameMenu(){
		SceneManager.LoadScene(MenuScene);
	}*/
	private void OnDisable(){
		buttonSelected = false;
}
	public void OnInstantInsanity(){
		SceneManager.LoadScene ("InstantScrollingbackground");
	}
	public void OnToTicTacToe(){
		SceneManager.LoadScene ("TicTacToeScrollingbackground");
	}
	public void OnToSokaban(){
		SceneManager.LoadScene ("SokabanScrollingbackground");
	}
	public void OnBlock(){
		SceneManager.LoadScene ("BlockScrollingbackground");
	}
	public void OnSnake(){
		SceneManager.LoadScene ("SnakeGameScrollingbackground");
	}
	public void OnReturntoMainMenu(){
		if (!isLoading) {
			isLoading = true;
			SceneManager.LoadScene ("ScrollingMainMenu");
		}
	}
	public void OnLevelSelect(){
		if (!isLoading) {
			isLoading = true;
			SceneManager.LoadScene ("World1");
		}
	}
	public void OnTicPlay(){
		if (!isLoading) {
			isLoading = true;
			SceneManager.LoadScene ("cubes");
		}
	}
	public void OnPlayInstantInsanity(){
		if (!isLoading) {
			isLoading = true;
			SceneManager.LoadScene ("InstantInsanity");
		}
	}
	public void OnPlayBrick(){
		if (!isLoading) {
			isLoading = true;
			SceneManager.LoadScene ("brick");
		}
	}
	public void OnReturnToLevelSelect(){
		if (!isLoading) {
			isLoading = true;
			SceneManager.LoadScene ("World1");
		}
	}

	public void OnQuit(){
		#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#else
		Application.Quit();
		#endif
	}
}
