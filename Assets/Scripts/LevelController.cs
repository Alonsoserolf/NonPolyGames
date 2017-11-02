using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour {

	public MainGrid grid;
	public Player player;

	enum Direction { UP, DOWN, LEFT, RIGHT };


	void OnEnable() {
		MainGrid.OnStart += OnGridStart;
		Player.OnStart += OnPlayerStart;

		InputController.OnUp += MoveUp;
		InputController.OnDown += MoveDown;
		InputController.OnRight += MoveRight;
		InputController.OnLeft += MoveLeft;
	}

	void OnGridStart(MainGrid grid) {
		this.grid = grid;
		StartLevel();
	}

	void OnPlayerStart(Player player) {
		this.player = player;
		StartLevel();
	}

	void StartLevel() {
		if (player == null || grid == null) return;

		var startingCell = grid.grid[0,0];
		player.SetCell(startingCell);

	}

	void MoveUp() { Move(Direction.UP); }

	void MoveDown() { Move(Direction.DOWN); }

	void MoveRight() { Move(Direction.RIGHT); }

	void MoveLeft() { Move(Direction.LEFT); }

	void Move(Direction direction) {
		switch (direction) {
			case Direction.UP:
				if (player.cell.y + 1 < grid.gridHeight)
					player.SetCell(grid.grid[player.cell.x, player.cell.y + 1]);
				break;
			case Direction.DOWN:
				if (player.cell.y - 1 >= 0)
					player.SetCell(grid.grid[player.cell.x, player.cell.y - 1]);
				break;
			case Direction.LEFT:
				if (player.cell.x - 1 >= 0)
					player.SetCell(grid.grid[player.cell.x - 1, player.cell.y]);
				break;
			case Direction.RIGHT:
				if (player.cell.x + 1 < grid.gridWidth)
					player.SetCell(grid.grid[player.cell.x + 1, player.cell.y]);
				break;
		}
	}

}
