using Rotation.Drawing;
using Rotation.Letters;
using Rotation.Tiles;

namespace Rotation.StandardBoard
{
    
    public class Square : IAnimatableItem
    {
		public Square(bool isSelectable, int x, int y)
		{
			IsSelectable = isSelectable;
		    XPos = x;
		    YPos = y;
		    Angle = 0;
			IsSelected = false;
		    InWord = false;
		}

        public int XPos { get; private set; }

        public int YPos { get; private set; }

	    public int Origin { get; set; }

		public bool IsSelected { get; set; }

		public bool IsSelectable { get; private set; }

		public bool HasTile { get { return Tile != null; } }

		public bool IsMainSelection { get; set; }

        public bool CanUseInWord { get; set; }

		public Tile Tile { get; set; }

        public bool InWord { get; set; }

		public Letter Letter
		{
			get { return Tile.Letter; }
		}

	    public int Angle { get; set; }

	    
	}
}