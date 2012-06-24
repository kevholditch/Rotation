using Microsoft.Xna.Framework.Graphics;
using Rotation.GameObjects.Tiles;

namespace Rotation.Drawing.ItemDrawers
{
    public interface ITileTextureCreator
    {
        bool CanCreateTexture(Tile tile);
        Texture2D Create(Tile tile);

    }
}