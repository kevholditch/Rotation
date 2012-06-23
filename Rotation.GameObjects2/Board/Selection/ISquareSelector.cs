namespace Rotation.GameObjects.Board.Selection
{
	public interface ISquareSelector
	{
		 void Select(IBoard board, int row, int col);
	}
}