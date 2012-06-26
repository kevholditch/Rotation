namespace Rotation.GameObjects.StandardBoard.Selection
{
	public interface ISquareSelector
	{
		void Select(Board board, int col, int row);
	    void DeSelect(Board board);
	}
}