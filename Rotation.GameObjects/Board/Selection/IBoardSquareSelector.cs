namespace Rotation.GameObjects.Board.Selection
{
	public interface IBoardSquareSelector
	{		
		void SelectSquares(IBoard board, int x, int y);
		void DeSelectAll(IBoard board);
	}
}