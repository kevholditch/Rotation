using System;
using System.Linq;
using Rotation.Letters;

namespace Rotation.Tiles
{
	public class StandardTileFactory : ITileFactory
	{
		private readonly ILetterLookup _letterLookup;
		private readonly Random _random;

		public StandardTileFactory(ILetterLookup letterLookup)
		{
			_letterLookup = letterLookup;
			_random = new Random(DateTime.Now.Millisecond);
		}

		public Tile Create()
		{						
			return new StandardTile(_letterLookup.Letters.ToList()[_random.Next(0, 26)]);
		}
	}
}