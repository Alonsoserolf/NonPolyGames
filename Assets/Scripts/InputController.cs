using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InputController : MonoBehaviour {

	static public event Action OnUp;
	static public event Action OnRight;
	static public event Action OnLeft;
	static public event Action OnDown;


	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Horizontal")) {
			if (Input.GetAxis("Horizontal") < 0)
				OnLeft();
			if (Input.GetAxis("Horizontal") > 0)
				OnRight();
		}
		if (Input.GetButtonDown("Vertical")) {
			if (Input.GetAxis("Vertical") < 0)
				OnDown();
			if (Input.GetAxis("Vertical") > 0)
				OnUp();
		}
		
	}
}
