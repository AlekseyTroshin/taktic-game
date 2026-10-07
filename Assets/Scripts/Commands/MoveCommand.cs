using UnityEngine;

public class MoveCommand : ICommand
{

	private Player _player;
	private Vector2 _targetCellPosition;
	private MovementManager _movementManager;

	public MoveCommand(
		Player player, 
		Vector2 targetCellPosition,
		MovementManager movementManager)
	{
		_player = player;
		_targetCellPosition = targetCellPosition;
		_movementManager = movementManager;
	}

	public void Execute()
	{
		_movementManager.Move(
			_player,
			_targetCellPosition
		);
	}

}