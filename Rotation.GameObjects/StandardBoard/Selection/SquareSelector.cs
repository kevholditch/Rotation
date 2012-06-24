namespace Rotation.GameObjects.StandardBoard.Selection
{
	public class SquareSelector : ISquareSelector
	{
		public void Select(Board board, int row, int col)
		{

		    DeSelect(board);

			var iteration = 1;

			board[row, col].IsSelected = true;
			board[row, col].IsMainSelection = true;

			while (board.CanGoAllDirections(row, col, iteration))
			{
				board[row - iteration, col].IsSelected = true;
				board[row + iteration, col].IsSelected = true;
				board[row, col - iteration].IsSelected = true;
				board[row, col + iteration].IsSelected = true;
				iteration++;
			}
		}

	    public void DeSelect(Board board)
	    {
            board.ForEachSquare(sq =>
            {
                sq.IsSelected = false;
                sq.IsMainSelection = false;
            });
	    }
	}
}