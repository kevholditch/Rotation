using Rotation.GameObjects.Letters;
using Rotation.GameObjects.Tiles;

namespace Rotation.GameObjects.Board
{
	public class Square 
	{
		public Square(bool isSelectable)
		{
			IsSelectable = isSelectable;
			IsSelected = false;			
		}		

		public bool IsSelected { get; set; }

		public bool IsSelectable { get; private set; }

		private Tile _tile;

		public void SetTile(Tile tile)
		{
			_tile = tile;
		}

		public Letter Letter
		{
			get { return _tile.Letter; }
		}

		
	}
}