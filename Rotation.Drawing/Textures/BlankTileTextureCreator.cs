using Microsoft.Xna.Framework.Graphics;
using Rotation.Drawing.ItemDrawers;
using Rotation.GameObjects.Tiles;

namespace Rotation.Drawing.Textures
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
            return _textureLoader.Load(DrawingConstants.BLANK_TILE);
        }
    }
}