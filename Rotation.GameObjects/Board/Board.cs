using System.Collections.Generic;

namespace Rotation.GameObjects.Board
{
	public class Board : IBoard
	{
		public Board(List<Line> rows, List<Line> columns)
		{
			Columns = columns;
			Rows = rows;
		}

		public List<Line> Rows { get; private set; }		
		public List<Line> Columns { get; private set; }
		public Square this[int x, int y] { get { return Rows[x].Squares[y]; } }
	}
}