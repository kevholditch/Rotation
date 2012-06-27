using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Rotation.Drawing.Textures;
using Rotation.GameObjects.StandardBoard;

namespace Rotation.Drawing.ItemDrawers
{
    public class SquareDrawer : ItemDrawerBase<Square>
    {
        private readonly ITileTextureFactory _tileTextureFactory;
        private readonly ISquareColourSelector _squareColourSelector;

        public SquareDrawer(ITileTextureFactory tileTextureFactory, ISquareColourSelector squareColourSelector)
        {
            _tileTextureFactory = tileTextureFactory;
            _squareColourSelector = squareColourSelector;
        }

        protected override void DrawImp(SpriteBatch spriteBatch, Square square)
        {
            var tileTextureCreator = _tileTextureFactory.Create(square.Tile);
            var texture = tileTextureCreator.Create(square.Tile);
            
            var colour = _squareColourSelector.SelectColour(square);
            
            var originX = ReverseSign((square.XPos-4.5f) * 40);
            var originY = ReverseSign((square.YPos-4.5f) * 40);

            spriteBatch.Draw(texture, new Vector2(190, 190), null, colour, MathHelper.ToRadians(square.Angle), new Vector2(originX, originY),
                             new Vector2(1, 1), SpriteEffects.None, 0);
     
        }

        private float ReverseSign(float input)
        {
            return input < 0 ? Math.Abs(input) : -input;
        }
    }
}