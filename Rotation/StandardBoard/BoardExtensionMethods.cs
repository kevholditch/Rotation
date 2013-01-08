using System;
using System.Collections.Generic;
using System.Linq;

namespace Rotation.StandardBoard
{
	public static class BoardExtensionMethods
	{
		public static void ForEachSquare(this IBoard board, Action<Square> action)
		{
			 foreach(var square in board.AllSquares())
				 	action(square);
		}

		public static List<Square> AllSquares(this IBoard board)
		{
			return board.Rows.SelectMany(row => row).ToList();
		}

		public static List<Square> AllSelectableSquaresWithTiles(this IBoard board)
		{
			return AllSquares(board).Where(sq => sq.IsSelectable && sq.HasTile).ToList();
		}
	}
}