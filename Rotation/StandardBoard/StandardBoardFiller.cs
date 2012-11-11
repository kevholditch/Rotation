using System.Linq;
using Rotation.Tiles;

namespace Rotation.StandardBoard
{
	public class StandardBoardFiller : IBoardFiller
	{
		private readonly ITileFactory _tileFactory;

		public StandardBoardFiller(ITileFactory tileFactory)
		{
			_tileFactory = tileFactory;
		}

		public void Fill(IBoard board)
		{
			foreach (var square in board.AllSquares().Where(sq => sq.IsSelectable && !sq.HasTile))
			{
				square.Tile = _tileFactory.Create();
			}
		}
	}
}