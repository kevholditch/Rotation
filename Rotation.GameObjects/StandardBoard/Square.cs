using Rotation.GameObjects.Drawing;
using Rotation.GameObjects.Letters;
using Rotation.GameObjects.Tiles;

namespace Rotation.GameObjects.StandardBoard
{
	public class Square : IDrawableItem
	{
		public Square(bool isSelectable, int x, int y)
		{
			IsSelectable = isSelectable;
		    XPos = x;
		    YPos = y;
			IsSelected = false;			
		}

        public int XPos { get; private set; }

        public int YPos { get; private set; }

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