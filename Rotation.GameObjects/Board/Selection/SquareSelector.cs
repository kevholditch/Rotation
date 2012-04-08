namespace Rotation.GameObjects.Board.Selection
{
	public class SquareSelector : ISquareSelector
	{
		public void Select(IBoard board, int row, int col)
		{			
			var iteration = 1;

			board[row, col].IsSelected = true;

			while (ShouldContinue(board, row, col, iteration))
			{
				board[row - iteration, col].IsSelected = true;
				board[row + iteration, col].IsSelected = true;
				board[row, col - iteration].IsSelected = true;
				board[row, col + iteration].IsSelected = true;
				iteration++;
			}
		}

		private bool ShouldContinue(IBoard board, int row, int col, int iteration)
		{
			return CanGoDown(board, row, col, iteration) &&
			       CanGoUp(board, row, col, iteration) &&
			       CanGoLeft(board, row, col, iteration) &&
			       CanGoRight(board, row, col, iteration);
		}

		private bool CanGoUp(IBoard board, int row, int col, int iteration)
		{
			return (row - iteration) >= 0 && board[row - iteration, col].IsSelectable;
		}

		private bool CanGoDown(IBoard board, int row, int col, int iteration)
		{
			return (row + iteration) < board.Columns[col].Squares.Count && board[row + iteration, col].IsSelectable;
		}

		private bool CanGoLeft(IBoard board, int row, int col, int iteration)
		{
			return (col - iteration) >= 0 && board[row, col - iteration].IsSelectable;
		}

		private bool CanGoRight(IBoard board, int row, int col, int iteration)
		{
			return (col + iteration) < board.Rows[row].Squares.Count && board[row, col + iteration].IsSelectable;
		}
	}
}