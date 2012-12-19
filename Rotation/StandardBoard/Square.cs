using Rotation.Drawing;
using Rotation.Tiles;

namespace Rotation.StandardBoard
{
    
    public class Square : IDrawableItem
    {
		public Square(bool isSelectable, int x, int y)
		{
			IsSelectable = isSelectable;
		    XPos = x;
		    YPos = y;
		    Angle = 0;
			IsSelected = false;
		}

        public int XPos { get; private set; }

        public int YPos { get; private set; }

	    public int Origin { get; set; }

        public int YOffset { get; set; }

		public bool IsSelected { get; set; }

		public bool IsSelectable { get; private set; }

		public bool HasTile { get { return Tile != null; } }

        public bool IsInBlock { get; set; }

		public bool IsMainSelection { get; set; }

		public Tile Tile { get; set; }

        public int Colour { get { return Tile.Colour; } }

	    public float Angle { get; set; }

	    
	}
}