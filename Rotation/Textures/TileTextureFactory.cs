using System.Collections.Generic;
using System.Linq;
using Rotation.ItemDrawers;
using Rotation.Tiles;

namespace Rotation.Textures
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