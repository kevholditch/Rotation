using System;
using Rotation.GameObjects.Letters;
using Rotation.GameObjects.Tiles;

namespace Rotation.GameObjects.Board
{
	public class Square 
	{

		public Guid Guid { get; set; }

		public Square()
		{
			Guid = Guid.NewGuid();
		}

		private Tile _tile;

		public void SetTile(Tile tile)
		{
			_tile = tile;
		}

		public Letter Letter
		{
			get { return _tile.Letter; }
		}

		
	}
}