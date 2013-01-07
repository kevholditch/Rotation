using System.Collections.Generic;
using System.Linq;
using Rotation.ItemDrawers;
using Rotation.StandardBoard;
using Rotation.Tiles;

namespace Rotation.Textures
{
    public class TileTextureFactory : ITileTextureFactory
    {
        private readonly IEnumerable<ISquareTextureCreator> _tileTextureCreators; 

        public TileTextureFactory(IEnumerable<ISquareTextureCreator> tileTextureCreators)
        {
            _tileTextureCreators = tileTextureCreators;
        }

        public ISquareTextureCreator Create(Square tile)
        {
            return _tileTextureCreators.First(t => t.CanCreateTexture(tile));
        }
    }
}