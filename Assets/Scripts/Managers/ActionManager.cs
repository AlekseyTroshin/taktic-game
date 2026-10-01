using System.Collections;
using UnityEngine;

public class ActionManager : MonoBehaviour
{

	private ActionQueue _actionQueue;

	private void Start()
	{
		_actionQueue = new ActionQueue();
	}

	public void SetMoveAction(MoveAction ma)
	{
		Debug.Log("---" + ma.Player.CellPosition + " --- " + ma.TargetCellPosition);
		_actionQueue.SetMoveAction(ma);
	}

	public void Show()
	{
		for (int i = 0; i < 3; i++)
		{
			var z = _actionQueue.GetMoveAction();
			Debug.Log(z.Player.CellPosition + " --- " + z.TargetCellPosition);
		}
	}

}