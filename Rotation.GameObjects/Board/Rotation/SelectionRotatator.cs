using Rotation.GameObjects.Board.Selection;
using Rotation.GameObjects.Tiles;

namespace Rotation.GameObjects.Board.Rotation
{
	public class SelectionRotatator : ISelectionRotatator
	{
		public void Left(IBoard board)
		{
			int numSquares = 1;

			var boardCoordinate = board.GetMainSelectedSquare();

			while (board.CanGoAllDirections(boardCoordinate.X, boardCoordinate.Y, numSquares))
			{
				Tile tile = board[boardCoordinate.X, boardCoordinate.Y - numSquares].Tile;

				board[boardCoordinate.X, boardCoordinate.Y - numSquares].Tile =
					board[boardCoordinate.X + numSquares, boardCoordinate.Y].Tile;

				board[boardCoordinate.X + numSquares, boardCoordinate.Y].Tile =
					board[boardCoordinate.X, boardCoordinate.Y + numSquares].Tile;

				board[boardCoordinate.X, boardCoordinate.Y + numSquares].Tile =
					board[boardCoordinate.X - numSquares, boardCoordinate.Y].Tile;

				board[boardCoordinate.X - numSquares, boardCoordinate.Y].Tile = 
					tile;
				numSquares++;
			}
		}

		public void Right(IBoard board)
		{
			int numSquares = 1;

			var boardCoordinate = board.GetMainSelectedSquare();

			while (board.CanGoAllDirections(boardCoordinate.X, boardCoordinate.Y, numSquares))
			{
				Tile tile = board[boardCoordinate.X, boardCoordinate.Y - numSquares].Tile;

				board[boardCoordinate.X, boardCoordinate.Y - numSquares].Tile =
					board[boardCoordinate.X - numSquares, boardCoordinate.Y].Tile;

				board[boardCoordinate.X - numSquares, boardCoordinate.Y].Tile =
					board[boardCoordinate.X, boardCoordinate.Y + numSquares].Tile;

				board[boardCoordinate.X, boardCoordinate.Y + numSquares].Tile =
					board[boardCoordinate.X + numSquares, boardCoordinate.Y].Tile;

				board[boardCoordinate.X + numSquares, boardCoordinate.Y].Tile =
					tile;
				numSquares++;
			}
		}
		
		
	}
}