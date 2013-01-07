using Microsoft.Xna.Framework.Graphics;
using Rotation.StandardBoard;
using Rotation.Tiles;

namespace Rotation.Textures
{
    public interface ISquareTextureCreator
    {
        bool CanCreateTexture(Square square);
        Texture2D Create(Square tile);

    }
}