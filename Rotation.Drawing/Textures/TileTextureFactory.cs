using System.Collections.Generic;
using Rotation.GameObjects.Tiles;
using System.Linq;

namespace Rotation.Drawing.ItemDrawers
{
    public class TileTextureFactory : ITileTextureFactory
    {
        private readonly IEnumerable<ITileTextureCreator> _tileTextureCreators;

        public TileTextureFactory(IEnumerable<ITileTextureCreator> tileTextureCreators)
        {
            _tileTextureCreators = tileTextureCreators;
        }

        public ITileTextureCreator Create(Tile tile)
        {
            return _tileTextureCreators.First(t => t.CanCreateTexture(tile));
        }
    }
}