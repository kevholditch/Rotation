using System.Collections.Generic;
using Rotation.Events;
using Rotation.StandardBoard.Selection;

namespace Rotation.StandardBoard.Rotation
{
	public class SelectionRotatator : ISelectionRotatator
	{
		public void Left(IBoard board)
		{
			var numSquares = 1;
			var boardCoordinate = board.GetMainSelectedSquare();
		    var changedSquareCoordinates = new List<BoardCoordinate>();

			while (board.IsSelectedAndCanGoInAllDirections(boardCoordinate.X, boardCoordinate.Y, numSquares))
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

                changedSquareCoordinates.Add(new BoardCoordinate(boardCoordinate.X, boardCoordinate.Y - numSquares));
                changedSquareCoordinates.Add(new BoardCoordinate(boardCoordinate.X + numSquares, boardCoordinate.Y));
                changedSquareCoordinates.Add(new BoardCoordinate(boardCoordinate.X, boardCoordinate.Y + numSquares));
                changedSquareCoordinates.Add(new BoardCoordinate(boardCoordinate.X - numSquares, boardCoordinate.Y));  

				numSquares++;
			}

            GameEvents.Raise(new RotatedLeftEvent{ BoardCoordinates = changedSquareCoordinates});

		}


	    public void Right(IBoard board)
		{
			int numSquares = 1;
			var boardCoordinate = board.GetMainSelectedSquare();
            var changedSquareCoordinates = new List<BoardCoordinate>();
   

			while (board.IsSelectedAndCanGoInAllDirections(boardCoordinate.X, boardCoordinate.Y, numSquares))
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

                changedSquareCoordinates.Add(new BoardCoordinate(boardCoordinate.X, boardCoordinate.Y - numSquares));
                changedSquareCoordinates.Add(new BoardCoordinate(boardCoordinate.X - numSquares, boardCoordinate.Y));
                changedSquareCoordinates.Add(new BoardCoordinate(boardCoordinate.X, boardCoordinate.Y + numSquares));
                changedSquareCoordinates.Add(new BoardCoordinate(boardCoordinate.X + numSquares, boardCoordinate.Y));

				numSquares++;
			}

            GameEvents.Raise(new RotatedRightEvent{BoardCoordinates = changedSquareCoordinates});
		
        
        }

	}
}