using System.Collections.Generic;

namespace Rotation.GameObjects.Board
{
	public class BoardFactory : IBoardFactory
	{
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

				if (lineSize < 9 && up)
				{
					lineSize += 2;					
				}
				else
				{
					up = false;
					lineSize -= 2;
				}
			}

			return new Board(rows, rows);
		}
	}
}