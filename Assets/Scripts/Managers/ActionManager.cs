using System.Collections;
using UnityEngine;

public class ActionManager : MonoBehaviour
{

	private CommandQueue _commandQueue;

	private void Start()
	{
		_commandQueue = new CommandQueue();
	}

	public void SetCommand(ICommand ma)
	{
		_commandQueue.SetCommand(ma);
	}

	public void Move()
	{
		if (_commandQueue.Empty()) return;

		StartCoroutine(MoveCommandQueueCoroutine());
	}

	private IEnumerator MoveCommandQueueCoroutine()
	{
		for (int i = 0; i < 3; i++)
		{
			ICommand iCommand = _commandQueue.Peek();
			iCommand.Execute();
			_commandQueue.Dequeue();
			yield return new WaitForSeconds(0.3f);
		}
	}

}