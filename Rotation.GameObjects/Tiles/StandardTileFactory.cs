using System;
using Rotation.GameObjects.Letters;
using System.Linq;

namespace Rotation.GameObjects.Tiles
{
	public class StandardTileFactory : ITileFactory
	{
		private readonly ILetterLookup _letterLookup;

		public StandardTileFactory(ILetterLookup letterLookup)
		{
			_letterLookup = letterLookup;
		}

		public Tile Create()
		{
			var random = new Random(DateTime.Now.Millisecond);

			var num = random.Next(0, 25);

			return new StandardTile(_letterLookup.Letters.Take(num).First());
		}
	}
}