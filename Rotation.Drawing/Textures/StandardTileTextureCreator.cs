using Microsoft.Xna.Framework.Graphics;
using Rotation.Drawing.ItemDrawers;
using Rotation.GameObjects.Tiles;

namespace Rotation.Drawing.Textures
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
            return _textureLoader.Load(string.Format("{0}{1}", DrawingConstants.STANDARD_TILE, tile.Letter.Value));
        }
    }
}