using System.Collections.Generic;
using Rotation.GameObjects.Drawing;

namespace Rotation.GameObjects.StandardBoard
{
    public class Board : IBoard
    {
		public Board(List<Line> columns, List<Line> rows)
		{
			Columns = columns;
			Rows = rows;
		}

		public List<Line> Rows { get; private set; }		
		public List<Line> Columns { get; private set; }
		public Square this[int x, int y] { get { return Columns[x].Squares[y]; } }

		public BoardCoordinate GetMainSelectedSquare()
		{			
			for (int i = 0; i < Columns.Count; i++)
			{
				for (int j = 0; j < Rows.Count; j++)
				{
					if (this[i, j].IsMainSelection)
						return new BoardCoordinate(i, j);
				}
			}

			return null;
		}

        public IEnumerable<IAnimatableItem> GetAnimatables()
	    {
	        return this.AllSquares();
	    }
	}
}