namespace Rotation.GameObjects.Board.Selection
{
	public class BoardSquareSelector : IBoardSquareSelector
	{
		public IBoard Select(IBoard board, int x, int y)
		{
			throw new System.NotImplementedException();
		}

		public IBoard DeSelectAll(IBoard board)
		{
			board.ForEachSquare(s => s.IsSelected = false);

			return board;
		}
	}
}