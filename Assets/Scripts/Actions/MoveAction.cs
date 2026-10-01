using UnityEngine;

public class MoveAction
{
	private Player _player;
	private Vector2 _targetCellPosition;

	public MoveAction(Player player, Vector2 position)
	{
		_player = player;
		_targetCellPosition = position;
	}

	public Player Player 
	{
		get { return _player; }
		set { _player = value; }
	}

	public Vector2 TargetCellPosition
	{
		get { return _targetCellPosition; }
		set { _targetCellPosition = value; }
	}
}

