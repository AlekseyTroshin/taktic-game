using System.Collections.Generic;
using System.Diagnostics;
using NUnit.Framework.Internal;

public class ActionQueue
{
	public Queue<ICommand> _moveCommand = new Queue<ICommand>();

	public Queue<ICommand> MoveCommands
	{
		get { return _moveCommand; }	
	}

	public void SetMoveCommand(ICommand command)
	{
		_moveCommand.Enqueue(command);
	}

	public bool Empty()
	{
		if (CanMoveCommand()) return false;

		return true;
	}

	public ICommand Peek()
	{
		if (CanMoveCommand()) return _moveCommand.Peek();

		return null;
	}

	public ICommand Dequeue()
	{
		if (CanMoveCommand()) return _moveCommand.Dequeue();

		return null;
	}

	private bool CanMoveCommand()
	{
		return (_moveCommand != null && _moveCommand.Count > 0);
	}

}