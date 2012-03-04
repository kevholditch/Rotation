using System;
using System.Collections.Generic;
using System.Linq;

namespace Rotation.GameObjects.Board
{
	public class BoardFactory : IBoardFactory
	{
		private readonly ILineIndexSequenceGenerator _sequenceGenerator;
		private readonly IRowIndexSequenceGenerator _rowIndexSequenceGenerator;

		public BoardFactory(IRowIndexSequenceGenerator rowIndexSequenceGenerator, ILineIndexSequenceGenerator sequenceGenerator)
		{
			_rowIndexSequenceGenerator = rowIndexSequenceGenerator;
			_sequenceGenerator = sequenceGenerator;
		}		
		


		public Board Create()
		{
			int boardSize = 9;

			int lineSize = 1;

			var rows = new List<Line>();

			bool up = true;

			for (int i = 0; i < boardSize; i++)
			{
				var currentRow = new List<Square>();
	
				for (int j = 0; j < lineSize; j++)
				{
					currentRow.Add(new Square());	
				}

				rows.Add(new Line(currentRow));

				if (lineSize < boardSize && up)
				{
					lineSize += 2;					
				}
				else
				{
					up = false;
					lineSize -= 2;
				}
			}

			var columns = new List<Line>();

			for (int i = 0; i < boardSize; i++)
			{
				var currentColumn = new List<Square>();

				var rowIndexes = _rowIndexSequenceGenerator.Create((boardSize - 1)/2, rows[i].Squares.Count).ToList();
				var squareIndexes = _sequenceGenerator.Create(rows[i].Squares.Count).ToList();

				for (int j = 0; j < rows[i].Squares.Count; j++)
				{
					int squareIndex = squareIndexes[j];

					if (i > ((boardSize - 1) / 2))
						squareIndex = (rows[rowIndexes[j]].Squares.Count - squareIndex) - 1;

					currentColumn.Add(rows[rowIndexes[j]].Squares[squareIndex]);
				}

				columns.Add(new Line(currentColumn));

			}

			return new Board(rows, columns);
		}
	}
}