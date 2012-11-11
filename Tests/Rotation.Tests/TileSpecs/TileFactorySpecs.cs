using Rotation.Letters;
using Rotation.Tiles;
using SubSpec;

namespace Rotation.GameObjects.sTests.TileSpecs
{
	public class TileFactorySpecs
	{
		[Specification]
		public void CanCreateAStandardTile()
		{
			var standardTileFactory = default(StandardTileFactory);
			var result = default(Tile);

			"Given that I have a standardTileFactory".Context(() => standardTileFactory = new StandardTileFactory(new LetterLookup()));

			"When I create a new tile".Do(() => result = standardTileFactory.Create());

			"Then the tile should be a standard tile".Observation(() => result.GetType().ShouldEqual(typeof (StandardTile)));
			
		}
		 
	}
}