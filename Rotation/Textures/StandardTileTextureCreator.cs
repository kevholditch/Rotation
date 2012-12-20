using Microsoft.Xna.Framework.Graphics;
using Rotation.Constants;
using Rotation.Engine;
using Rotation.Tiles;

namespace Rotation.Textures
{
    public class StandardTileTextureCreator : BaseTileTextureCreator<StandardTile>
    {
        private readonly ITextureLoader _textureLoader;

        public StandardTileTextureCreator(ITextureLoader textureLoader)
        {
            _textureLoader = textureLoader;
        }
        
        protected override Texture2D CreateImp(Tile tile)
        {
            return _textureLoader.Load(DrawingConstants.Tiles.BLANK_TILE);
        }
    }
}