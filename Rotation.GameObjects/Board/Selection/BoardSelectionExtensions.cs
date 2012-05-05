namespace Rotation.GameObjects.Board.Selection
{
	public static class BoardSelectionExtensions
	{
		public static void DeselectAll(this IBoard board)
		{
			board.ForEachSquare(sq =>
			                    	{
			                    		sq.IsSelected = false;
			                    		sq.IsMainSelection = false;
			                    	});
		}

		public static bool CanGoUp(this IBoard board, int row, int col, int numSquares)
		{
			return (row - numSquares) >= 0 && board[row - numSquares, col].IsSelectable;
		}

		public static bool CanGoDown(this IBoard board, int row, int col, int numSquares)
		{
			return (row + numSquares) < board.Columns[col].Squares.Count && board[row + numSquares, col].IsSelectable;
		}

		public static bool CanGoLeft(this IBoard board, int row, int col, int numSquares)
		{
			return (col - numSquares) >= 0 && board[row, col - numSquares].IsSelectable;
		}

		public static bool CanGoRight(this IBoard board, int row, int col, int numSquares)
		{
			return (col + numSquares) < board.Rows[row].Squares.Count && board[row, col + numSquares].IsSelectable;
		}

		public static bool CanGoAllDirections(this IBoard board, int row, int col, int numSquares)
		{
			return CanGoUp(board, row, col, numSquares) &&
			       CanGoRight(board, row, col, numSquares) &&
			       CanGoDown(board, row, col, numSquares) &&
			       CanGoLeft(board, row, col, numSquares);
		}

	}
}