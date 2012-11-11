namespace Rotation.StandardBoard.Selection
{
	public interface ISquareSelector
	{
		void Select(IBoard board, int col, int row);
	    void DeSelect(IBoard board);
	}
}