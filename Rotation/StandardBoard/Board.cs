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

            CentreSquare = new BoardCoordinate((Columns.Count - 1) / 2, (Rows.Count - 1)/2);
		}

        public List<List<Square>> Rows { get; private set; }
        public List<List<Square>> Columns { get; private set; }
		public Square this[int x, int y] { get { return Columns[x][y]; } }


        public BoardCoordinate CentreSquare { get; private set; }

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

        public IEnumerable<IDrawableItem> GetAnimatables()
	    {
	        return this.AllSquares();
	    }
	}
}