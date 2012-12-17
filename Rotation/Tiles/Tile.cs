using Rotation.Letters;

namespace Rotation.Tiles
{
	public abstract class Tile 
	{
		protected Tile(int colour)
		{
		    Colour = colour;
		}

        public int Colour { get; set;  }
	}
}