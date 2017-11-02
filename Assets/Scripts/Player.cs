using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public delegate void StartHandler(Player player);
	public static event StartHandler OnStart = delegate { };

	public Cell cell;

	void Start() {
		OnStart(this);
	}

	public void SetCell(Cell cell) {
		this.cell = cell;
		transform.position = new Vector3(cell.positionX, 0, cell.positionY);
	}
}
