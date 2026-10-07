using UnityEngine;
using UnityEngine.UI;

namespace PatternCommand.Scripts
{

	public abstract class Example
	{

		[SerializeField] private Button btnStepStraight;
		[SerializeField] private Button btnStepDiagonal;
		[SerializeField] private Button btnUndo;
		[SerializeField] private Transform pivotTransform;
		[SerializeField] private float stepDistance;

		private List<MoveCommand> moveJournal = new List<MoveCommand>();

		private void OnEnagle()
		{
			btnStepStraight.onClick.AddListener(StepStraight);
			btnStepDiagonal.onClick.AddListener(StepDiagonal);
			btnUndo.onClick.AddListener(UndoLastMove);
		}

		private void OnDisable()
		{
			btnStepStraight.onClick.RemoveListener(StepStraight);
			btnStepDiagonal.onClick.RemoveListener(StepDiagonal);
			btnUndo.onClick.RemoveListener(UndoLastMove);
		}

		private void StepStraight()
		{
			var move = new MoveStraightCommand(pivotTransform, stepDistance);

			move.Execute();

			moveJournal.Add(move);
		}

		private void StepDiagonal()
		{
			var move = new MoveStraightCommand(pivotTransform, stepDistance);

			move.Execute();

			moveJournal.Add(move);Debug.Log("Step Siagonal");
		}

		private void UndoLastMove()
		{
			var move = new MoveStraightCommand(pivotTransform, stepDistance);

			move.Execute();

			moveJournal.Add(move);
		}

	}

}