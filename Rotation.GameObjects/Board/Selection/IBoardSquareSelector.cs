namespace Rotation.GameObjects.Board.Selection
{
	public interface IBoardSquareSelector
	{		
		IBoard Select(IBoard board, int x, int y);
		IBoard DeSelectAll(IBoard board);
	}
}