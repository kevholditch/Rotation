using System.Collections.Generic;
using Rotation.GameObjects.Drawing;

namespace Rotation.GameObjects.StandardBoard
{
	public class Board : IGetDrawableItems
	{
		public Board(List<Line> rows, List<Line> columns)
		{
			Columns = columns;
			Rows = rows;
		}

		public List<Line> Rows { get; private set; }		
		public List<Line> Columns { get; private set; }
		public Square this[int x, int y] { get { return Columns[x].Squares[y]; } }

		public BoardCoordinate GetMainSelectedSquare()
		{			
			for (int i = 0; i < Rows.Count; i++)
			{
				for (int j = 0; j < Columns.Count; j++)
				{
					if (this[i, j].IsMainSelection)
						return new BoardCoordinate(j, i);
				}
			}

			return null;
		}

	    public IEnumerable<IDrawableItem> GetDrawables()
	    {
	        return this.AllSquares();
	    }
	}
}