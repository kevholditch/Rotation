namespace Rotation.GameObjects.StandardBoard.Selection
{
	public static class BoardSelectionExtensions
	{
	
		public static bool CanGoUp(this Board board, int col, int row, int numSquares)
		{
			return (row - numSquares) >= 0 && board[col, row - numSquares].IsSelectable;
		}

		public static bool CanGoDown(this Board board, int col, int row, int numSquares)
		{
			return (row + numSquares) < board.Columns[col].Squares.Count && board[col, row + numSquares].IsSelectable;
		}

		public static bool CanGoLeft(this Board board, int col, int row, int numSquares)
		{
			return (col - numSquares) >= 0 && board[col - numSquares, row].IsSelectable;
		}

		public static bool CanGoRight(this Board board, int col, int row, int numSquares)
		{
			return (col + numSquares) < board.Rows[row].Squares.Count && board[col + numSquares, row].IsSelectable;
		}

		public static bool CanGoAllDirections(this Board board, int col, int row, int numSquares)
		{
			return CanGoUp(board, col, row, numSquares) &&
                   CanGoRight(board, col, row, numSquares) &&
                   CanGoDown(board, col, row, numSquares) &&
                   CanGoLeft(board, col, row, numSquares);
		}

	}
}