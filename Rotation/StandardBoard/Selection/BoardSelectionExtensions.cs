namespace Rotation.StandardBoard.Selection
{
	public static class BoardSelectionExtensions
	{
	
		public static bool CanGoUp(this IBoard board, int col, int row, int numSquares)
		{
			return (row - numSquares) >= 0 && board[col, row - numSquares].IsSelectable;
		}

		public static bool CanGoDown(this IBoard board, int col, int row, int numSquares)
		{
			return (row + numSquares) < board.Columns[col].Count && board[col, row + numSquares].IsSelectable;
		}

		public static bool CanGoLeft(this IBoard board, int col, int row, int numSquares)
		{
			return (col - numSquares) >= 0 && board[col - numSquares, row].IsSelectable;
		}

		public static bool CanGoRight(this IBoard board, int col, int row, int numSquares)
		{
			return (col + numSquares) < board.Rows[row].Count && board[col + numSquares, row].IsSelectable;
		}

		public static bool CanGoAllDirections(this IBoard board, int col, int row, int numSquares)
		{
			return CanGoUp(board, col, row, numSquares) &&
                   CanGoRight(board, col, row, numSquares) &&
                   CanGoDown(board, col, row, numSquares) &&
                   CanGoLeft(board, col, row, numSquares);
		}

	}
}