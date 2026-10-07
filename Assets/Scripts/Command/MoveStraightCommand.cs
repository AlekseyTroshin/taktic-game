using UnityEngine;

namespace PatternCommand.Scripts
{

	public abstract class MoveStraightCommand : MoveCommand
	{
		protected Transfrom transfrom;
		protected float stepDistance;

		public MoveCommand(Transform transfrom, float stepDistance = 1f)
		{
			this.transfrom = transfrom;
			this.stepDistance = stepDistance;
		}

		public void Execute()
		{
			transfrom.position += Vector3.right * stepDistance;
		}

		public void Undo()
		{

		}
	}

}