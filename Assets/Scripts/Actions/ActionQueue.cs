using System.Collections.Generic;
using System.Diagnostics;
using NUnit.Framework.Internal;

public class ActionQueue
{
	public Queue<MoveAction> _moveAction = new Queue<MoveAction>();

	public void SetMoveAction(MoveAction ma)
	{
		_moveAction.Enqueue(ma);
	}

	public MoveAction GetMoveAction()
	{
		if (_moveAction != null && _moveAction.Count > 0)
		{
			return _moveAction.Dequeue();
		}

		return null;
	}	
}