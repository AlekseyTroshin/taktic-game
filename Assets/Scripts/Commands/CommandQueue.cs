using System.Collections.Generic;
using System.Diagnostics;
using NUnit.Framework.Internal;

public class CommandQueue
{
	public Queue<ICommand> _commands = new Queue<ICommand>();

	public Queue<ICommand> Commands
	{
		get { return _commands; }	
	}

	public void SetCommand(ICommand command)
	{
		_commands.Enqueue(command);
	}

	public bool Empty()
	{
		if (HasCommand()) return false;

		return true;
	}

	public ICommand Peek()
	{
		if (HasCommand()) return _commands.Peek();

		return null;
	}

	public ICommand Dequeue()
	{
		if (HasCommand()) return _commands.Dequeue();

		return null;
	}

	private bool HasCommand()
	{
		return (_commands != null && _commands.Count > 0);
	}

}