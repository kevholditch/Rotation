using System;

namespace Rotation.Tiles
{
	public class StandardTileFactory : ITileFactory
	{
		private readonly Random _random;

		public StandardTileFactory()
		{
			_random = new Random(DateTime.Now.Millisecond);
		}

		public Tile Create()
		{						
			return new StandardTile(_random.Next(0, 2));
		}
	}
}