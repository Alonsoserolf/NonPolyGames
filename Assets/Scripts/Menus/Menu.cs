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
		StartCoroutine (LoadingLevelInst());
	}
	IEnumerator LoadingLevelInst(){
		yield return new WaitForSeconds(1f);
		SceneManager.LoadScene ("InstantScrollingbackground");
	}
	public void OnToTicTacToe(){
		StartCoroutine (LoadingLevelTic());
		//SceneManager.LoadScene ("TicTacToeScrollingbackground");
	}
	IEnumerator LoadingLevelTic(){
		yield return new WaitForSeconds(1f);
		SceneManager.LoadScene ("TicTacToeScrollingbackground");
	}
	public void OnToSokaban(){
		StartCoroutine (LoadingLevelSok());
		//SceneManager.LoadScene ("SokabanScrollingbackground");
	}
	IEnumerator LoadingLevelSok(){
		yield return new WaitForSeconds(1f);
		SceneManager.LoadScene ("SokabanScrollingbackground");
	}

	public void OnBlock(){
		StartCoroutine (LoadingLevelBlo());
		//SceneManager.LoadScene ("BlockScrollingbackground");
	}
	IEnumerator LoadingLevelBlo(){
		yield return new WaitForSeconds(1f);
		SceneManager.LoadScene ("BlockScrollingbackground");
	}
	public void OnSnake(){
		StartCoroutine (LoadingLevelSna());
		//SceneManager.LoadScene ("SnakeGameScrollingbackground");
	}
	IEnumerator LoadingLevelSna(){
		yield return new WaitForSeconds(1f);
		SceneManager.LoadScene ("SnakeGameScrollingbackground");
	}
	public void OnReturntoMainMenu(){
		StartCoroutine (LoadingLevelReturn());
		/*if (!isLoading) {
			isLoading = true;
			SceneManager.LoadScene ("ScrollingMainMenu");
		}*/
	}
	IEnumerator LoadingLevelReturn(){
		yield return new WaitForSeconds(1f);
		if (!isLoading) {
			isLoading = true;
			SceneManager.LoadScene ("ScrollingMainMenu");
		}
	}
	public void OnLevelSelect(){
		StartCoroutine (LoadingLevelLvlSelect());
		/*if (!isLoading) {
			isLoading = true;
			SceneManager.LoadScene ("World1");
		}*/
	}
	IEnumerator LoadingLevelLvlSelect(){
		yield return new WaitForSeconds(1f);
		if (!isLoading) {
			isLoading = true;
			SceneManager.LoadScene ("World1");
		}
	}
	public void OnTicPlay(){
		StartCoroutine (LoadingLevelTicPlay());
		/*if (!isLoading) {
			isLoading = true;
			SceneManager.LoadScene ("cubes");
		}*/
	}
	IEnumerator LoadingLevelTicPlay(){
		yield return new WaitForSeconds(1f);
		if (!isLoading) {
			isLoading = true;
			SceneManager.LoadScene ("cubes");
		}
	}
	public void OnPlayInstantInsanity(){
		StartCoroutine (LoadingLevelInstPlay());
		/*if (!isLoading) {
			isLoading = true;
			SceneManager.LoadScene ("InstantInsanity");
		}*/
	}
	IEnumerator LoadingLevelInstPlay(){
		yield return new WaitForSeconds(1f);
		if (!isLoading) {
			isLoading = true;
			SceneManager.LoadScene ("InstantInsanity");
		}
	}
	public void OnPlayBrick(){
		StartCoroutine (LoadingLevelBrickPlay());
		/*if (!isLoading) {
			isLoading = true;
			SceneManager.LoadScene ("brick");
		}*/
	}
	IEnumerator LoadingLevelBrickPlay(){
		yield return new WaitForSeconds(1f);
		if (!isLoading) {
			isLoading = true;
			SceneManager.LoadScene ("brick");
		}
	}
	public void OnReturnToLevelSelect(){
		StartCoroutine (LoadingLevelReturnLvlSelect());
		/*if (!isLoading) {
			isLoading = true;
			SceneManager.LoadScene ("World1");
		}*/
	}
	IEnumerator LoadingLevelReturnLvlSelect(){
		yield return new WaitForSeconds(1f);
		if (!isLoading) {
			isLoading = true;
			SceneManager.LoadScene ("World1");
		}
	}
	public void OnQuit(){
		StartCoroutine (LoadingLevelQuit());
		/*Debug.Log ("pressing Quit");
		#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#else
		Application.Quit();
		#endif
		*/
	}
	IEnumerator LoadingLevelQuit(){
		yield return new WaitForSeconds(1f);
		Debug.Log ("pressing Quit");
		#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#else
		Application.Quit();
		#endif
	}

}
