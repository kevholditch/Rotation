using System.Collections.Generic;
using System.Linq;
using Rotation.GameObjects.Board.Sequences;

namespace Rotation.GameObjects.Board
{
	public class BoardFactory : IBoardFactory
	{

		RowIndexSequence rowIndexSequence = new RowIndexSequence();
		private const int BOARD_SIZE = 9;

		public Board Create()
		{

			var rows = new List<Line>();			

			for (int i = 0; i < BOARD_SIZE; i++)
			{
				var currentRow = new List<Square>();

				var selectableSquares = rowIndexSequence.Get(i, BOARD_SIZE);

				for (int j = 0; j < BOARD_SIZE; j++)
				{
					currentRow.Add(new Square(selectableSquares.Contains(j)));	
				}

				rows.Add(new Line(currentRow));
			}

			var cols = new List<Line>();

			for (int i = 0; i < BOARD_SIZE; i++)
			{
				var currentCol = new List<Square>();				

				for (int j = 0; j < BOARD_SIZE; j++)
				{
					currentCol.Add(rows[j].Squares[i]);
				}

				cols.Add(new Line(currentCol));
			}


			return new Board(rows, cols);
		}
	}
}