using Rotation.Textures;
using Rotation.Tiles;

namespace Rotation.ItemDrawers
{
    public interface ITileTextureFactory
    {
        ITileTextureCreator Create(Tile tile);
    }

    
}