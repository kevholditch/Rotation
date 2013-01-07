using Rotation.StandardBoard;
using Rotation.Textures;
using Rotation.Tiles;

namespace Rotation.ItemDrawers
{
    public interface ITileTextureFactory
    {
        ISquareTextureCreator Create(Square tile);
    }

    
}