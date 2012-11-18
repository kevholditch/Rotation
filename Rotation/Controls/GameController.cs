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
        private readonly ISquareSelectable _squareSelectable;
        public BoardCoordinate CurrentSelectedSquare { get; private set; }

        public GameController(ISquareSelector squareSelector, ISelectionRotatator selectionRotatator, ISquareSelectable squareSelectable, IBoard board)
        {
            _squareSelector = squareSelector;
            _selectionRotatator = selectionRotatator;
            _board = board;
            _squareSelectable = squareSelectable;
        }

        public void Initialise()
        {
            CurrentSelectedSquare = _board.CentreSquare;
            _squareSelector.Select(_board, CurrentSelectedSquare.X, CurrentSelectedSquare.Y);
        }

        public void SelectSquare(int x, int y)
        {
            if (_squareSelectable.CanSelectSquare(_board, x, y))
            {
                CurrentSelectedSquare = new BoardCoordinate(x, y);
                _squareSelector.Select(_board, x, y);
            }
        }

        public void MoveSelectionUp()
        {
            if (_squareSelectable.CanSelectSquare(_board, CurrentSelectedSquare.X, CurrentSelectedSquare.Y))
            {
                CurrentSelectedSquare = new BoardCoordinate(CurrentSelectedSquare.X, CurrentSelectedSquare.Y - 1);
                _squareSelector.Select(_board, CurrentSelectedSquare.X, CurrentSelectedSquare.Y);
            }
        }

        public void MoveSelectionDown()
        {
            if (_squareSelectable.CanSelectSquare(_board, CurrentSelectedSquare.X, CurrentSelectedSquare.Y))
            {
                CurrentSelectedSquare = new BoardCoordinate(CurrentSelectedSquare.X, CurrentSelectedSquare.Y + 1);
                _squareSelector.Select(_board, CurrentSelectedSquare.X, CurrentSelectedSquare.Y);
            }
        }

        public void MoveSelectionLeft()
        {
            if (_squareSelectable.CanSelectSquare(_board, CurrentSelectedSquare.X, CurrentSelectedSquare.Y))
            {
                CurrentSelectedSquare = new BoardCoordinate(CurrentSelectedSquare.X - 1, CurrentSelectedSquare.Y);
                _squareSelector.Select(_board, CurrentSelectedSquare.X, CurrentSelectedSquare.Y);
            }
        }

        public void MoveSelectionRight()
        {
            if (_squareSelectable.CanSelectSquare(_board, CurrentSelectedSquare.X, CurrentSelectedSquare.Y))
            {
                CurrentSelectedSquare = new BoardCoordinate(CurrentSelectedSquare.X + 1, CurrentSelectedSquare.Y);
                _squareSelector.Select(_board, CurrentSelectedSquare.X, CurrentSelectedSquare.Y);
            }
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