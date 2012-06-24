using System;
using System.Collections.Generic;
using System.Linq;

namespace Rotation.GameObjects.StandardBoard
{
	public static class BoardExtensionMethods
	{
		public static void ForEachSquare(this Board board, Action<Square> action)
		{
			 foreach(var square in board.AllSquares())
				 	action(square);
		}

		public static List<Square> AllSquares(this Board board)
		{
			return board.Rows.SelectMany(row => row.Squares).ToList();
		}

		public static List<Square> AllSelectableSquaresWithTiles(this Board board)
		{
			return AllSquares(board).Where(sq => sq.IsSelectable && sq.HasTile).ToList();
		}
	}
}