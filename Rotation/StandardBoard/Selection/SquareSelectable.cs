namespace Rotation.StandardBoard.Selection
{
    public class SquareSelectable : ISquareSelectable
    {
        public bool CanSelectSquare(IBoard board, int col, int row)
        {
            if (col < 0 || col > board.Columns.Count - 1)
                return false;

            if (row < 0 || row > board.Rows.Count - 1)
                return false;

            return board[col, row].IsSelectable;
        }
    }
}