namespace Rotation.StandardBoard.Selection
{
    public interface ISquareSelectable
    {
        bool CanSelectSquare(IBoard board, int col, int row);
    }
}