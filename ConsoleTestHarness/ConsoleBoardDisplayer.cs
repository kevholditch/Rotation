using System;
using Rotation.GameObjects.StandardBoard;

namespace ConsoleTestHarness
{
	public class ConsoleBoardDisplayer
	{

		private readonly Board _board;

		public ConsoleBoardDisplayer(Board board)
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