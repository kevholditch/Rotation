using Rotation.Letters;

namespace Rotation.Tiles
{
	public abstract class Tile 
	{
		protected Tile(Letter letter)
		{
			Letter = letter;
		}

		public Letter Letter { get; set; }
	}
}