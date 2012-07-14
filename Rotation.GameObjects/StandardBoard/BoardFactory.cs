using System.Collections.Generic;
using System.Linq;
using Rotation.GameObjects.StandardBoard.Sequences;

namespace Rotation.GameObjects.StandardBoard
{
	public class BoardFactory : IBoardFactory
	{

		RowIndexSequence rowIndexSequence = new RowIndexSequence();
		private const int BOARD_SIZE = 9;

		public Board Create()
		{

			var rows = new List<List<Square>>();			

			for (int i = 0; i < BOARD_SIZE; i++)
			{
				var currentRow = new List<Square>();

				var selectableSquares = rowIndexSequence.Get(i, BOARD_SIZE);

				for (int j = 0; j < BOARD_SIZE; j++)
				{
				    var square = new Square(selectableSquares.Contains(j), i, j);
				    square.CanUseInWord = square.IsSelectable;
					currentRow.Add(square);	
				}

				rows.Add(new List<Square>(currentRow));
			}

			var cols = new List<List<Square>>();

			for (int i = 0; i < BOARD_SIZE; i++)
			{
				var currentCol = new List<Square>();				

				for (int j = 0; j < BOARD_SIZE; j++)
				{
					currentCol.Add(rows[j][i]);
				}

				cols.Add(new List<Square>(currentCol));
			}


			return new Board(rows, cols);
		}
	}
}