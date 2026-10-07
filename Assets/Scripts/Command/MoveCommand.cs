using UnityEngine;

namespace PatternCommand.Scripts
{

	public abstract class MoveCommand
	{
		protected Transfrom transfrom;
		protected float stepDistance;

		public MoveCommand(Transform transfrom, float stepDistance = 1f)
		{
			this.transfrom = transfrom;
			this.stepDistance = stepDistance;
		}

		public abstract void Execute();
		public abstract void Undo();
	}

}