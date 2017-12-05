using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MainGrid : MonoBehaviour {

	public delegate void StartHandler (MainGrid grid);
	public static event StartHandler OnStart = delegate { };

	public int width;
	public int height;
	public Cell[,] grid;

	public float gridWidth;
	public float gridHeight;
	public float cellWidth;
	public float cellHeight;

	void OnEnable () {
		if (width <= 0) width = 10;
		if (height <= 0) height = 10;

		grid = new Cell[width, height];
		gridWidth = transform.localScale.x;
		gridHeight = transform.localScale.y;
		cellWidth =	gridWidth / width;
		cellHeight = gridHeight / height;


		for (int x = 0; x < width; x++) {
			for (int y = 0; y < height; y++) {
				grid[x, y] = new Cell();
				grid[x, y].positionX = (-gridWidth / 2) + (x * cellWidth) + (cellWidth / 2);
				grid[x, y].positionY = (-gridHeight / 2) + (y * cellHeight) + (cellHeight / 2);
				grid[x, y].x = x;
				grid[x, y].y = y;
			}

		}

	}
	
	void Start () {
		OnStart(this);
	}
}
