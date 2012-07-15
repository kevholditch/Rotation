using Rotation.Drawing.Textures;
using Rotation.GameObjects.Tiles;

namespace Rotation.Drawing.ItemDrawers
{
    public interface ITileTextureFactory
    {
        ITileTextureCreator Create(Tile tile);
    }

    
}