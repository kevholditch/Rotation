using System.Collections.Generic;
using Rotation.GameObjects.Drawing;
using Rotation.GameObjects.Events;
using Rotation.GameObjects.StandardBoard.Selection;
using Rotation.GameObjects.Tiles;

namespace Rotation.GameObjects.StandardBoard.Rotation
{
	public class SelectionRotatator : ISelectionRotatator
	{
		public void Left(IBoard board)
		{
			var numSquares = 1;

			var boardCoordinate = board.GetMainSelectedSquare();

		    var changedSquareCoordinates = new List<BoardCoordinate>();

			while (board.CanGoAllDirections(boardCoordinate.X, boardCoordinate.Y, numSquares))
			{
				var tile = board[boardCoordinate.X, boardCoordinate.Y - numSquares].Tile;

				board[boardCoordinate.X, boardCoordinate.Y - numSquares].Tile =
					board[boardCoordinate.X + numSquares, boardCoordinate.Y].Tile;

				board[boardCoordinate.X + numSquares, boardCoordinate.Y].Tile =
					board[boardCoordinate.X, boardCoordinate.Y + numSquares].Tile;

				board[boardCoordinate.X, boardCoordinate.Y + numSquares].Tile =
					board[boardCoordinate.X - numSquares, boardCoordinate.Y].Tile;

				board[boardCoordinate.X - numSquares, boardCoordinate.Y].Tile = 
					tile;

                SetSquareLeft(board[boardCoordinate.X, boardCoordinate.Y - numSquares]);
                SetSquareLeft(board[boardCoordinate.X + numSquares, boardCoordinate.Y]);
                SetSquareLeft(board[boardCoordinate.X, boardCoordinate.Y + numSquares]);
                SetSquareLeft(board[boardCoordinate.X - numSquares, boardCoordinate.Y]);

                changedSquareCoordinates.Add(new BoardCoordinate(boardCoordinate.X, boardCoordinate.Y - numSquares));
                changedSquareCoordinates.Add(new BoardCoordinate(boardCoordinate.X + numSquares, boardCoordinate.Y));
                changedSquareCoordinates.Add(new BoardCoordinate(boardCoordinate.X, boardCoordinate.Y + numSquares));
                changedSquareCoordinates.Add(new BoardCoordinate(boardCoordinate.X - numSquares, boardCoordinate.Y));  

				numSquares++;
			}

            GameEvents.Raise(new RotatedLeftEvent{ BoardCoordinates = changedSquareCoordinates});

		}

        private void SetSquareLeft(IRotationAnimationItem square)
        {
            square.Angle = 90;
            square.Direction = RotationDirection.AntiClockwise;
        }

	    public void Right(IBoard board)
		{
			int numSquares = 1;

			var boardCoordinate = board.GetMainSelectedSquare();

            var changedSquareCoordinates = new List<BoardCoordinate>();
   

			while (board.CanGoAllDirections(boardCoordinate.X, boardCoordinate.Y, numSquares))
			{
				var tile = board[boardCoordinate.X, boardCoordinate.Y - numSquares].Tile;

				board[boardCoordinate.X, boardCoordinate.Y - numSquares].Tile =
					board[boardCoordinate.X - numSquares, boardCoordinate.Y].Tile;

				board[boardCoordinate.X - numSquares, boardCoordinate.Y].Tile =
					board[boardCoordinate.X, boardCoordinate.Y + numSquares].Tile;

				board[boardCoordinate.X, boardCoordinate.Y + numSquares].Tile =
					board[boardCoordinate.X + numSquares, boardCoordinate.Y].Tile;

				board[boardCoordinate.X + numSquares, boardCoordinate.Y].Tile =
					tile;

                SetSquareRight(board[boardCoordinate.X, boardCoordinate.Y - numSquares]);
                SetSquareRight(board[boardCoordinate.X - numSquares, boardCoordinate.Y]);
                SetSquareRight(board[boardCoordinate.X, boardCoordinate.Y + numSquares]);
                SetSquareRight(board[boardCoordinate.X + numSquares, boardCoordinate.Y]);

                changedSquareCoordinates.Add(new BoardCoordinate(boardCoordinate.X, boardCoordinate.Y - numSquares));
                changedSquareCoordinates.Add(new BoardCoordinate(boardCoordinate.X - numSquares, boardCoordinate.Y));
                changedSquareCoordinates.Add(new BoardCoordinate(boardCoordinate.X, boardCoordinate.Y + numSquares));
                changedSquareCoordinates.Add(new BoardCoordinate(boardCoordinate.X + numSquares, boardCoordinate.Y));

				numSquares++;
			}

            GameEvents.Raise(new RotatedRightEvent{BoardCoordinates = changedSquareCoordinates});
		
        
        }

	    private void SetSquareRight(IRotationAnimationItem square)
	    {
	        square.Angle = -90;
	        square.Direction = RotationDirection.Clockwise;
	    }
	}
}