using Microsoft.Xna.Framework.Graphics;
using Rotation.Tiles;

namespace Rotation.Textures
{
    public interface ITileTextureCreator
    {
        bool CanCreateTexture(Tile tile);
        Texture2D Create(Tile tile);

    }
}