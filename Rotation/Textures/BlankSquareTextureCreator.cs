using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoRotation;
using Rotation.Constants;
using Rotation.StandardBoard;

namespace Rotation.Textures
{
    public class BlankSquareTextureCreator : ISquareTextureCreator
    {

        private Texture2D _cachedTexture;

        public bool CanCreateTexture(Square square)
        {
            return !square.HasTile;
        }

        public Texture2D Create(Square tile)
        {
            if (_cachedTexture != null)
                return _cachedTexture;

            var texture = new Texture2D(RotationGame.CurrentGraphicsDevice, DrawingConstants.Tiles.TILE_WIDTH, DrawingConstants.Tiles.TILE_HEIGHT, false, SurfaceFormat.Color);

            var colours = new Color[DrawingConstants.Tiles.TILE_HEIGHT * DrawingConstants.Tiles.TILE_WIDTH];

            for (int i = 0; i < colours.Length; i++)
                colours[i] = Color.White;

            texture.SetData(colours);
            _cachedTexture = texture;

            return _cachedTexture;
        }
    }
}