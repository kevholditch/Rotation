using System;
using Rotation.GameObjects.Board;

namespace ConsoleTestHarness
{
	public class ConsoleBoardDisplayer
	{

		private readonly IBoard _board;

		public ConsoleBoardDisplayer(IBoard board)
		{
			_board = board;
		}

		public void Display()
		{
			Console.Clear();

			for (int x = 0; x < _board.Rows.Count; x++)
			{
				for (int y = 0; y < _board.Columns.Count; y++)
				{
					var currentSquare = _board[x, y];
					Console.Write("[{0}]", currentSquare.HasTile ? currentSquare.Letter.Value : ' ');
				}
				Console.WriteLine();
			}
		}

		public void ShowSelectableSquares()
		{
			Console.Clear();

			for (int x = 0; x < _board.Rows.Count; x++)
			{
				for (int y = 0; y < _board.Columns.Count; y++)
				{
					var currentSquare = _board[x, y];
					Console.Write("[{0}]", currentSquare.IsSelectable ? 'X' : ' ');
				}
				Console.WriteLine();
			}
		}
	}
}