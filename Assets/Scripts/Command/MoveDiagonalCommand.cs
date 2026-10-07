using UnityEngine;

namespace PatternCommand.Scripts
{

	public abstract class MoveDiagonalCommand : MoveCommand
	{
		
		private Vector3 directionDiagonal = new Vector3(1f, -1f, 0f).normalized;

		public MoveCommand(Transform transfrom, float stepDistance = 1f) : 
			base(transfrom, stepDistance)
		{
			this.transfrom = transfrom;
			this.stepDistance = stepDistance;
		}

		public void Execute()
		{
			
			transfrom.position += directionDiagonal * stepDistance;
		}

		public void Undo()
		{
			transfrom.position -= directionDiagonal * stepDistance;
		}
	}

}