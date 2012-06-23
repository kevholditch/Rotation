using Rotation.GameObjects.Drawing;
using Rotation.GameObjects.Letters;

namespace Rotation.GameObjects.Tiles
{
	public abstract class Tile : DrawableItem
	{
		protected Tile(Letter letter)
		{
			Letter = letter;
		}

		public Letter Letter { get; set; }
	}
}