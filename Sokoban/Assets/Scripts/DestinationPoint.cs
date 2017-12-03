using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DestinationPoint : MonoBehaviour {


	public Text blocksLeftText;
	private static int blocksLeft;
	private static int currentLevel;

	void Start() {
		blocksLeft = GameObject.FindGameObjectsWithTag("DestinationPoint").Length;
		setBlocksLeft();
		currentLevel = SceneManager.GetActiveScene().buildIndex + 1;
	}

	void Update() {

	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "MoveableBlock") {
			blocksLeft--;
			setBlocksLeft();
			Destroy(other.gameObject);
			if (blocksLeft == 0) {
				int totalLevels = SceneManager.sceneCount;
				string level = "Level " + currentLevel++;
				SceneManager.LoadScene ("Level 2");
			}
		}
	}

	void setBlocksLeft() {
		blocksLeftText.text = "Blocks left: " + blocksLeft.ToString();
	}
}