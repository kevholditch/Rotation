using Rotation.StandardBoard;
using Rotation.StandardBoard.Rotation;
using Rotation.StandardBoard.Selection;

namespace Rotation.Controls
{
    public class GameController : IGameController
    {
        private readonly ISquareSelector _squareSelector;
        private readonly ISelectionRotatator _selectionRotatator;
        private readonly IBoard _board;
        public BoardCoordinate CurrentSelectedSquare { get; private set; }

        public GameController(ISquareSelector squareSelector, ISelectionRotatator selectionRotatator, IBoard board)
        {
            _squareSelector = squareSelector;
            _selectionRotatator = selectionRotatator;
            _board = board;
        }

        public void Initialise()
        {
            CurrentSelectedSquare = _board.CentreSquare;
        }

        public void SelectSquare(int x, int y)
        {
            _squareSelector.Select(_board, x, y);
        }

        public void MoveSelectionUp()
        {
            CurrentSelectedSquare = new BoardCoordinate(CurrentSelectedSquare.X, CurrentSelectedSquare.Y - 1);
            SelectSquare(CurrentSelectedSquare.X, CurrentSelectedSquare.Y);
        }

        public void MoveSelectionDown()
        {
            CurrentSelectedSquare = new BoardCoordinate(CurrentSelectedSquare.X, CurrentSelectedSquare.Y + 1);
            SelectSquare(CurrentSelectedSquare.X, CurrentSelectedSquare.Y);
        }

        public void MoveSelectionLeft()
        {
            CurrentSelectedSquare = new BoardCoordinate(CurrentSelectedSquare.X - 1, CurrentSelectedSquare.Y);
            SelectSquare(CurrentSelectedSquare.X, CurrentSelectedSquare.Y);
        }

        public void MoveSelectionRight()
        {
            CurrentSelectedSquare = new BoardCoordinate(CurrentSelectedSquare.X + 1, CurrentSelectedSquare.Y);
            SelectSquare(CurrentSelectedSquare.X, CurrentSelectedSquare.Y);
        }

        public void RotateRight()
        {
            _selectionRotatator.Right(_board);
        }

        public void RotateLeft()
        {
            _selectionRotatator.Left(_board);
        }
    }
}