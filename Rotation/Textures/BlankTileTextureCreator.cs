using Microsoft.Xna.Framework.Graphics;
using Rotation.Engine;
using Rotation.Tiles;

namespace Rotation.Textures
{
    public class BlankTileTextureCreator : ITileTextureCreator
    {
        private readonly ITextureLoader _textureLoader;

        public BlankTileTextureCreator(ITextureLoader textureLoader)
        {
            _textureLoader = textureLoader;
        }

        public bool CanCreateTexture(Tile tile)
        {
            return tile == null;
        }

        public Texture2D Create(Tile tile)
        {
            return _textureLoader.Load(DrawingConstants.Tiles.BLANK_TILE);
        }
    }
}