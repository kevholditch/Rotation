using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoRotation;
using Rotation.Constants;
using Rotation.StandardBoard;

namespace Rotation.Textures
{
    public class StandardSquareTextureCreator : ISquareTextureCreator
    {

        private Texture2D _cachedTexture;

        public bool CanCreateTexture(Square square)
        {
            return square.HasTile && !square.IsSelected;
        }

        public Texture2D Create(Square tile)
        {
            if (_cachedTexture != null)
                return _cachedTexture;

            var texture = new Texture2D(RotationGame.CurrentGraphicsDevice, DrawingConstants.Tiles.TILE_WIDTH, DrawingConstants.Tiles.TILE_HEIGHT, false, SurfaceFormat.Color);

            var colours = new Color[DrawingConstants.Tiles.TILE_HEIGHT*DrawingConstants.Tiles.TILE_WIDTH];


            const int boarderWidth = 4;

            for (int x = 0; x < DrawingConstants.Tiles.TILE_WIDTH; x++)
            {
                for (int y = 0; y < DrawingConstants.Tiles.TILE_HEIGHT; y++)
                {
                    if (x <= boarderWidth || x >= DrawingConstants.Tiles.TILE_WIDTH - boarderWidth ||
                        y <= boarderWidth || y >= DrawingConstants.Tiles.TILE_HEIGHT - boarderWidth)
                    {
                        colours[x + y * DrawingConstants.Tiles.TILE_WIDTH] = Color.Black;
                    }
                    else
                    {
                        colours[x + y * DrawingConstants.Tiles.TILE_WIDTH] = Color.White;
                    }
                }
            }

            texture.SetData(colours);

            _cachedTexture = texture;

            return _cachedTexture;
        }


    }


}