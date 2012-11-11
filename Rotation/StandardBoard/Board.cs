using System.Collections.Generic;
using Rotation.Drawing;

namespace Rotation.StandardBoard
{
    public class Board : IBoard
    {
		public Board(List<List<Square>> columns, List<List<Square>> rows)
		{
			Columns = columns;
			Rows = rows;
		}

        public List<List<Square>> Rows { get; private set; }
        public List<List<Square>> Columns { get; private set; }
		public Square this[int x, int y] { get { return Columns[x][y]; } }

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