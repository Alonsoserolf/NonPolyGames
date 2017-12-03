using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour {

	Vector3 pos;
	private int movesMade;
	public float speed = 3.0f;
	GameObject floor;
	GameObject[] immovableObjects;

	public Text movesMadeText;


	// Use this for initialization
	void Start () {
		movesMade = 0;
		setMovesMade();
		floor = GameObject.FindGameObjectWithTag("Floor");
		pos = transform.position;
		pos.Set(-(floor.transform.localScale.x / 2) + 1, .5f, -(floor.transform.localScale.z / 2) + 1);
		immovableObjects = GameObject.FindGameObjectsWithTag("ImmovableBlock");
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 lastPos = pos;
		if (Input.GetKey(KeyCode.A) && transform.position == pos) {        // Left
            pos += Vector3.left;
			movesMade++;
        }
        if (Input.GetKey(KeyCode.D) && transform.position == pos) {        // Right
            pos += Vector3.right;
			movesMade++;
        }
        if (Input.GetKey(KeyCode.W) && transform.position == pos) {        // Forward
            pos += Vector3.forward;
			movesMade++;
        }
        if (Input.GetKey(KeyCode.S) && transform.position == pos) {        // Backward
            pos += Vector3.back;
			movesMade++;
        }
        if (InBounds() && ValidMove()) {
			transform.position = Vector3.MoveTowards(transform.position, pos, Time.deltaTime * speed);
			setMovesMade();
        } else {
        	pos = lastPos;
        	movesMade--;
        	setMovesMade();
        }
	}

	// Checks if where the position the player wants to move is within the boundaries of the floor.
	bool InBounds() {
		if (pos.x < (floor.transform.localScale.x / 2) && pos.x > -(floor.transform.localScale.z / 2)
			&& pos.z < (floor.transform.localScale.z / 2) && pos.z > -(floor.transform.localScale.z / 2)) {
			return true;
		} else 
			return false;
	}

	// Checks if the position the player wants to move in is a valid space on the grid. (ie. not moving into an immovable block)
	bool ValidMove () {
		for (int i = 0; i < immovableObjects.Length; i++) {
			if (pos.x == immovableObjects[i].transform.position.x && pos.z == immovableObjects[i].transform.position.z) {
				return false;
			}
		}
		return true;
	}

	void setMovesMade() {
		movesMadeText.text = "Moves made: " + movesMade.ToString();
	}
}