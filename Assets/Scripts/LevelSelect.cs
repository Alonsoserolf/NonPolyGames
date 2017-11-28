using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour {

	private const int buttonsPerRow = 3;
	private const int rowsPerPage = 5;

	private static int numColumns = 2 * buttonsPerRow + 1;
	private static int numRows = 2 * rowsPerPage + 1;

	private float gridBoxWidth = Screen.width/numColumns;
	private float gridBoxHeight = Screen.height / numRows;

	private static int numLevels = 15;
	private static int completedLevels = 4;

	void onGUI(){
		for (var i = 0; i < numLevels; i++) {
			//if (i > completedLevels) {
			//	GUI.enabled = false;
			//}
			int buttonRow = (int)i / buttonsPerRow;
			int gridRow = 2*buttonRow +1;
			float top = gridBoxHeight * gridRow;

			int buttonIndex = i % buttonsPerRow;
			int gridColumn = 2 * buttonIndex + 1;
			float left = gridBoxWidth * gridColumn;

			var levelName = "Level " +(i+1);
			if (GUI.Button (new Rect (left, top, gridBoxWidth, gridBoxHeight), levelName)) {
				SceneManager.LoadScene (levelName);
			}
		}
	}

}
