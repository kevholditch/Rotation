using System.Collections.Generic;
using Rotation.Drawing.ItemDrawers;
using Rotation.GameObjects.Tiles;
using System.Linq;

namespace Rotation.Drawing.Textures
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