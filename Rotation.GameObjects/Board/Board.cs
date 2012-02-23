using System.Collections.Generic;

namespace Rotation.GameObjects.Board
{
	public class Board
	{
		public Board(List<Line> columns, List<Line> rows)
		{
			Columns = columns;
			Rows = rows;
		}

		public List<Line> Rows { get; private set; }		
		public List<Line> Columns { get; private set; } 
	}
}