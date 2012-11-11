namespace Rotation.StandardBoard.Selection
{
	public class SquareSelector : ISquareSelector
	{
		public void Select(IBoard board, int col, int row)
		{

		    DeSelect(board);

			var iteration = 1;

			board[col, row].IsSelected = true;
			board[col, row].IsMainSelection = true;

			while (board.CanGoAllDirections(col, row, iteration))
			{
				board[col, row - iteration].IsSelected = true;
				board[col, row + iteration].IsSelected = true;
				board[col - iteration, row].IsSelected = true;
				board[col + iteration, row].IsSelected = true;
				iteration++;
			}
		}

	    public void DeSelect(IBoard board)
	    {
            board.ForEachSquare(sq =>
            {
                sq.IsSelected = false;
                sq.IsMainSelection = false;
            });
	    }
	}
}