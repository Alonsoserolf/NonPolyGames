using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour {

	public int X; // Length of X axis
	public int Y; // Length of Y axis
	public int Z; // Length of Z axis

	// Dimensions of Grid
	private int[,,] Grid;

	private GameObject[] boxes;
	private GameObject[] destinations;
	

	public int xPos = 0, yPos = 0, zPos = 0;
	public bool xAxis = true, yAxis = false;

	private int destinationsMet = 0;

	private int movesMade = 0;
	public Text movesMadeText;
	public Text axisText;
	public Text boxesLeftText;

	public Image black;
	public Animator anim;

	public int currentLevel;

	void Start () {

		// Finds all boxes in game.
		boxes = GameObject.FindGameObjectsWithTag("GridBox");

		// Finds all destinations in game.
		destinations = GameObject.FindGameObjectsWithTag("GridDestination");

		// # of rows in grid.
		GameObject[] rows = GameObject.FindGameObjectsWithTag("GridRow");
		// # of columns in grid.
		GameObject[] columns = GameObject.FindGameObjectsWithTag("GridColumn");
		// # of blocks in grid.
		int totalBlocks = (int)GameObject.FindGameObjectsWithTag("GridBlock").Length + GameObject.FindGameObjectsWithTag("GridDestination").Length;

		// Dimensions of grid.
		X = totalBlocks / columns.Length;
		Y = rows.Length;
		Z = columns.Length / rows.Length;

		// Instantiation of grid.
		Grid = new int[X, Y, Z];

		// Sets all spaces in Grid that are empty to 0.
		for (int i = 0; i < X; i++) {
			for (int j = 0; j < Y; j++) {
				for (int k = 0; k < Z; k++) {
					Grid[i, j, k] = 0;
				}
			}
		}

		// Sets all spaces with destination points in Grid to 2.
		for (int i = 0; i < destinations.Length; i++) {
			int x = (int)destinations[i].transform.position.x;
			int y = (int)destinations[i].transform.position.y;
			int z = (int)destinations[i].transform.position.z;
			Grid[x, y, z] = 2;
		}

		// Sets all spaces with boxes in Grid to 3.
		for (int i = 0; i < boxes.Length; i++) {
			int x = (int)boxes[i].transform.position.x;
			int y = (int)boxes[i].transform.position.y;
			int z = (int)boxes[i].transform.position.z;
			Grid[x, y, z] = 3;
		}

		transform.position = new Vector3(0, 0, 0);

		// Gets current level.
		currentLevel = System.Convert.ToInt32(SceneManager.GetActiveScene().name.Substring(SceneManager.GetActiveScene().name.Length - 1));
	}


	void Update () {

		// If moving along the X axis.
		if (xAxis) {
			bool hasMoved = false;

			// UP
			if (Input.GetKeyDown("up")) {
				if (zPos + 1 < Z) {
					if (Grid[xPos, yPos, zPos + 1] == 3) {
						if (zPos + 2 < Z && Grid[xPos, yPos, zPos + 2] != 1) {
							transform.Translate(0.0f, 0.0f, 1.0f);
							zPos++;
							int x = getBox(xPos, yPos, zPos);
							boxes[x].transform.Translate(0.0f, 0.0f, 1.0f);
							Grid[xPos, yPos, zPos] = 0;
							if (Grid[xPos, yPos, zPos + 1] == 2) {
								print("Reached destination point!");
								destinationsMet++;
								print(destinationsMet);
							}
							Grid[xPos, yPos, zPos + 1] = 3;
							movesMade++;
						}
						hasMoved = true;
					}
					if (!hasMoved) {
						transform.Translate(0.0f, 0.0f, 1.0f);
						zPos++;
						movesMade++;
					}
					if (destinationsMet == destinations.Length) {
						StartCoroutine(nextLevel());
					}
				}
			}

			// DOWN
			if (Input.GetKeyDown("down")) {
				if (zPos - 1 >= 0) {
					if (Grid[xPos, yPos, zPos - 1] == 3) {
						if (zPos - 2 >= 0 && Grid[xPos, yPos, zPos - 2] != 1) {
							transform.Translate(0.0f, 0.0f, -1.0f);
							zPos--;
							int x = getBox(xPos, yPos, zPos);
							boxes[x].transform.Translate(0.0f, 0.0f, -1.0f);
							Grid[xPos, yPos, zPos] = 0;
							if (Grid[xPos, yPos, zPos - 1] == 2) {
								print("Reached destination point!");
								destinationsMet++;
								print(destinationsMet);
							}
							Grid[xPos, yPos, zPos - 1] = 3;
							movesMade++;
						}
						hasMoved = true;
					}
					if (!hasMoved) {
						transform.Translate(0.0f, 0.0f, -1.0f);
						zPos--;
						movesMade++;
					}
					if (destinationsMet == destinations.Length) {
						StartCoroutine(nextLevel());
					}
				}
			}

			// LEFT
			if (Input.GetKeyDown("left")) {
				if (xPos - 1 >= 0) {
					if (Grid[xPos - 1, yPos, zPos] == 3) {
						if (xPos - 2 >= 0 && Grid[xPos - 2, yPos, zPos] != 1) {
							transform.Translate(-1.0f, 0.0f, 0.0f);
							xPos--;
							int x = getBox(xPos, yPos, zPos);
							boxes[x].transform.Translate(-1.0f, 0.0f, 0.0f);
							Grid[xPos, yPos, zPos] = 0;
							if (Grid[xPos - 1, yPos, zPos] == 2) {
								print("Reached destination point!");
								destinationsMet++;
								print(destinationsMet);
							}
							Grid[xPos - 1, yPos, zPos] = 3;
							movesMade++;
						}
						hasMoved = true;
					}
					if (!hasMoved) {
						transform.Translate(-1.0f, 0.0f, 0.0f);
						xPos--;
						movesMade++;
					}
					if (destinationsMet == destinations.Length) {
						StartCoroutine(nextLevel());
					}
				}
			}

			// RIGHT
			if (Input.GetKeyDown("right")) {
				
				if (xPos + 1 < X) {
					if (Grid[xPos + 1, yPos, zPos] == 3) {
						if (xPos + 2 < X && Grid[xPos + 2, yPos, zPos] != 1) {
							transform.Translate(1.0f, 0.0f, 0.0f);
							xPos++;
							int x = getBox(xPos, yPos, zPos);
							boxes[x].transform.Translate(1.0f, 0.0f, 0.0f);
							Grid[xPos, yPos, zPos] = 0;
							if (Grid[xPos + 1, yPos, zPos] == 2) {
								print("Reached destination point!");
								destinationsMet++;
								print(destinationsMet);
							}
							Grid[xPos + 1, yPos, zPos] = 3;
							movesMade++;
						}
						hasMoved = true;
					}
					if (!hasMoved) {
						transform.Translate(1.0f, 0.0f, 0.0f);
						xPos++;
						movesMade++;
					}
					if (destinationsMet == destinations.Length) {
						StartCoroutine(nextLevel());
					}
				}
			}

			if (Input.GetKeyDown("x")) {
				print("Movement origin has been switched to the X axis!");
				xAxis = true;
				yAxis = false;
			}

			if (Input.GetKeyDown("y")) {
				print("Movement origin has been switched to the Y axis!");
				xAxis = false;
				yAxis = true;
			}
		}

		// If moving along the Y axis.
		if (yAxis) {
			bool hasMoved = false;

			// UP
			if (Input.GetKeyDown("up")) {
				if (yPos + 1 < Y) {
					if (Grid[xPos, yPos + 1, zPos] == 3) {
						if (yPos + 2 < Y && Grid[xPos, yPos + 2, zPos] != 1) {
							transform.Translate(0.0f, 1.0f, 0.0f);
							yPos++;
							int x = getBox(xPos, yPos, zPos);
							boxes[x].transform.Translate(0.0f, 1.0f, 0.0f);
							Grid[xPos, yPos, zPos] = 0;
							if (Grid[xPos, yPos + 1, zPos] == 2) {
								print("Reached destination point!");
								destinationsMet++;
								print(destinationsMet);
							}
							Grid[xPos, yPos + 1, zPos] = 3;
							movesMade++;
						}
						hasMoved = true;
					}
					if (!hasMoved) {
						transform.Translate(0.0f, 1.0f, 0.0f);
						yPos++;
						movesMade++;
					}
					if (destinationsMet == destinations.Length) {
						StartCoroutine(nextLevel());
					}
				}
			}

			// DOWN
			if (Input.GetKeyDown("down")) {
				if (yPos - 1 >= 0) {
					if (Grid[xPos, yPos - 1, zPos] == 3) {
						if (yPos - 2 >= 0 && Grid[xPos, yPos - 2, zPos] != 1) {
							transform.Translate(0.0f, -1.0f, 0.0f);
							yPos--;
							int x = getBox(xPos, yPos, zPos);
							boxes[x].transform.Translate(0.0f, -1.0f, 0.0f);
							Grid[xPos, yPos, zPos] = 0;
							if (Grid[xPos, yPos - 1, zPos] == 2) {
								print("Reached destination point!");
								destinationsMet++;
								print(destinationsMet);
							}
							Grid[xPos, yPos - 1, zPos] = 3;
							movesMade++;
						}
						hasMoved = true;
					}
					if (!hasMoved) {
						transform.Translate(0.0f, -1.0f, 0.0f);
						yPos--;
						movesMade++;
					}
					if (destinationsMet == destinations.Length) {
						StartCoroutine(nextLevel());
					}
				}
			}

			// LEFT
			if (Input.GetKeyDown("left")) {
				if (xPos - 1 >= 0) {
					if (Grid[xPos - 1, yPos, zPos] == 3) {
						if (xPos - 2 >= 0 && Grid[xPos - 2, yPos, zPos] != 1) {
							transform.Translate(-1.0f, 0.0f, 0.0f);
							xPos--;
							int x = getBox(xPos, yPos, zPos);
							boxes[x].transform.Translate(-1.0f, 0.0f, 0.0f);
							Grid[xPos, yPos, zPos] = 0;
							if (Grid[xPos - 1, yPos, zPos] == 2) {
								print("Reached destination point!");
								destinationsMet++;
								print(destinationsMet);
							}
							Grid[xPos - 1, yPos, zPos] = 3;
							movesMade++;
						}
						hasMoved = true;
					}
					if (!hasMoved) {
						transform.Translate(-1.0f, 0.0f, 0.0f);
						xPos--;
						movesMade++;
					}
					if (destinationsMet == destinations.Length) {
						StartCoroutine(nextLevel());
					}
				}
			}

			// RIGHT
			if (Input.GetKeyDown("right")) {
				if (xPos + 1 < X) {
					if (Grid[xPos + 1, yPos, zPos] == 3) {
						if (xPos + 2 < X && Grid[xPos + 2, yPos, zPos] < 3) {
							transform.Translate(1.0f, 0.0f, 0.0f);
							xPos++;
							int x = getBox(xPos, yPos, zPos);
							boxes[x].transform.Translate(1.0f, 0.0f, 0.0f);
							Grid[xPos, yPos, zPos] = 0;
							if (Grid[xPos + 1, yPos, zPos] == 2) {
								print("Reached destination point!");
								destinationsMet++;
								print(destinationsMet);
							}
							Grid[xPos + 1, yPos, zPos] = 3;
							movesMade++;
						}
						hasMoved = true;
					}
					if (!hasMoved) {
						transform.Translate(1.0f, 0.0f, 0.0f);
						xPos++;
						movesMade++;
					}
					if (destinationsMet == destinations.Length) {
						StartCoroutine(nextLevel());
					}
				}
			}
			if (Input.GetKeyDown("x")) {
				print("Movement origin has been switched to the X axis!");
				xAxis = true;
				yAxis = false;
			}
			if (Input.GetKeyDown("y")) {
				print("Movement origin has been switched to the Y axis!");
				xAxis = false;
				yAxis = true;
			}
		}

	}

	void LateUpdate() {
		setAxisText();
		setBoxesLeftText();
		setMovesMadeText();
	}


	// Returns box number.
	public int getBox(int X, int Y, int Z) {
		for (int i = 0; i < boxes.Length; i++) {
			int x = (int)boxes[i].transform.position.x;
			int y = (int)boxes[i].transform.position.y;
			int z = (int)boxes[i].transform.position.z;
			if (x == X && y == Y && z == Z) {
				return i;
			}
		}
		return -1;
	}

	void setMovesMadeText() {
		movesMadeText.text = "Moves made: " + movesMade.ToString();
	}


	void setBoxesLeftText() {
		boxesLeftText.text = "Boxes left: " + (destinations.Length - destinationsMet);
	}

	void setAxisText() {
		if (xAxis) {
			axisText.text = "Using X axis!";

		} else {
			axisText.text = "Using Y axis!";
		}
	}

	IEnumerator nextLevel() {
		int totalLevels = SceneManager.sceneCount;
		string level = "Level1." + ++currentLevel;
		anim.SetBool("Fade", true);
		yield return new WaitUntil(()=>black.color.a == 1);
		if (currentLevel > totalLevels) {
			Application.Quit();
		}
		SceneManager.LoadScene(level);
	}
}