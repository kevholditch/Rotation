namespace Rotation.GameObjects.Board.Selection
{
	public class SquareSelector : ISquareSelector
	{
		public void Select(IBoard board, int row, int col)
		{			
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
	}
}