using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DestinationPoint : MonoBehaviour {


	public Text blocksLeftText;
	private static int blocksLeft;
	private static int currentLevel;

	//-------------ivan lvl select-----------
	protected string currLevel;
	protected int worldIndex;
	protected int levelIndex;
	//-------------------------

	void Start() {
		blocksLeft = GameObject.FindGameObjectsWithTag("DestinationPoint").Length;
		setBlocksLeft();
		currentLevel = SceneManager.GetActiveScene().buildIndex + 1;
		currLevel = SceneManager.GetActiveScene().name;
		//currentLevel = Application.loadedLevelName;
	}

	void Update() {

	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "MoveableBlock") {
			blocksLeft--;
			setBlocksLeft();
			Destroy(other.gameObject);
			//-------------ivan lvl select-----------------
			UnlockLevels();
			//------------------------------
			if (blocksLeft == 0) {
				int totalLevels = SceneManager.sceneCount;
				string level = "Level " + currentLevel++;
				SceneManager.LoadScene ("Level1.2");
			}
		}
	}

	void setBlocksLeft() {
		blocksLeftText.text = "Blocks left: " + blocksLeft.ToString();
	}
	//----ivan lvl select--------------
	protected void  UnlockLevels (){
		//set the playerprefs value of next level to 1 to unlock
		for(int i = 0; i < LockLevel.worlds; i++){
			Debug.Log ("inside for loop destination point locklevelworlds, worldIndex " +worldIndex+" levelIndex "+levelIndex);
			for(int j = 1; j < LockLevel.levels; j++){  
				Debug.Log ("inside 2nd loop destination point locklevel.levels");
				if(currLevel == "Level"+(i+1).ToString() +"." +j.ToString()){
					Debug.Log ("inside if loop destination point currlevel"+worldIndex+" "+levelIndex);
					worldIndex  = (i+1);
					levelIndex  = (j+1);
					Debug.Log ("inside if afterloop destination point currlevel"+worldIndex+" "+levelIndex);
					PlayerPrefs.SetInt("level"+worldIndex.ToString() +":" +levelIndex.ToString(),1);
				}
			}
		}
		//load the World1 level
		//Application.LoadLevel("World1");
		//SceneManager.LoadScene("World1");
	}

	//
}