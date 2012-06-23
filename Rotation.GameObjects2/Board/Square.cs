using Rotation.GameObjects.Drawing;
using Rotation.GameObjects.Letters;
using Rotation.GameObjects.Tiles;

namespace Rotation.GameObjects.Board
{
	public class Square : DrawableItem
	{
		public Square(bool isSelectable)
		{
			IsSelectable = isSelectable;
			IsSelected = false;			
		}		

		public bool IsSelected { get; set; }

		public bool IsSelectable { get; private set; }

		public bool HasTile { get { return Tile != null; } }

		public bool IsMainSelection { get; set; }	

		public Tile Tile { get; set; }

		public Letter Letter
		{
			get { return Tile.Letter; }
		}

		
	}
}