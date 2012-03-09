namespace Rotation.GameObjects.Board.Selection
{
	public class BoardSquareSelector : IBoardSquareSelector
	{
		public void SelectSquares(IBoard board, int x, int y)
		{
			throw new System.NotImplementedException();
		}

		public void DeSelectAll(IBoard board)
		{
			board.ForEachSquare(s => s.IsSelected = false);			
		}
	}
}