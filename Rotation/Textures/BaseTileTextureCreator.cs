using Microsoft.Xna.Framework.Graphics;
using Rotation.Tiles;

namespace Rotation.Textures
{
    public abstract class BaseTileTextureCreator<T> : ITileTextureCreator where T : Tile
    {
        public bool CanCreateTexture(Tile tile)
        {
            return tile is T;
        }

        public Texture2D Create(Tile tile)
        {
            return CreateImp(tile);
        }

        protected abstract Texture2D CreateImp(Tile tile);
    }
}