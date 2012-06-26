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
            
            var xPos = (square.XPos*texture.Width) + 10;
            var yPos = (square.YPos*texture.Width) + 10;

            var colour = _squareColourSelector.SelectColour(square);
            
            var originX = ((square.XPos-4.5f) * 40);
            var originY = ((square.YPos-4.5f) * 40);

            spriteBatch.Draw(texture, new Vector2(190, 190), null, colour, MathHelper.ToRadians(45), new Vector2(originX, originY),
                             new Vector2(1, 1), SpriteEffects.None, 0);
            //spriteBatch.Draw(texture, new Vector2(xPos, yPos), null, colour, MathHelper.ToRadians(45), new Vector2(0, 0), 
            //                 new Vector2(1, 1), SpriteEffects.None, 0);
        }

        private float ReverseSign(float input)
        {
            return input < 0 ? Math.Abs(input) : -input;
        }
    }
}