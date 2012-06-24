using System.Linq;
using Rotation.GameObjects.Tiles;

namespace Rotation.GameObjects.StandardBoard
{
	public class BoardFiller : IBoardFiller
	{
		private readonly ITileFactory _tileFactory;

		public BoardFiller(ITileFactory tileFactory)
		{
			_tileFactory = tileFactory;
		}

		public void Fill(Board board)
		{
			foreach (var square in board.AllSquares().Where(sq => sq.IsSelectable && !sq.HasTile))
			{
				square.Tile = _tileFactory.Create();
			}
		}
	}
}