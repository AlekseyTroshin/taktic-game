using System.Collections;
using UnityEngine;

public class ActionManager : MonoBehaviour
{

	private ActionQueue _actionQueue;
	private MovementManager _movementManager;

	private void Start()
	{
		_actionQueue = new ActionQueue();
		_movementManager = FindFirstObjectByType<MovementManager>();
	}

	public void SetMoveAction(MoveAction ma)
	{
		Debug.Log("---" + ma.Player.CellPosition + " --- " + ma.TargetCellPosition);
		_actionQueue.SetMoveAction(ma);
	}

	public void Move()
	{
		if (_actionQueue.Empty()) return;

		StartCoroutine(MoveActionQueueCoroutine());
	}

	private IEnumerator MoveActionQueueCoroutine()
	{
		for (int i = 0; i < 3; i++)
		{
			MoveAction ma = _actionQueue.Peek();
			_movementManager.Move(
				ma.Player, 
				ma.TargetCellPosition
			);
			_actionQueue.DeQueue();
			yield return new WaitForSeconds(0.3f);
		}
	}

}