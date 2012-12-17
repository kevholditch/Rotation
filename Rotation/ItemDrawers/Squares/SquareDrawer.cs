using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Rotation.StandardBoard;
using Rotation.Textures;

namespace Rotation.ItemDrawers.Squares
{
    public class SquareDrawer : ItemDrawerBase<Square>
    {
        private readonly ITileTextureFactory _tileTextureFactory;
        private readonly ISquareColourSelector _squareColourSelector;
        private readonly ISquarePositionCalculator _squarePositionCalculator;
        private readonly ISquareOriginCalculator _squareOriginCalculator;
        private readonly ISquareDepthCalculator _squareDepthCalculator;

        public SquareDrawer(ITileTextureFactory tileTextureFactory, ISquareColourSelector squareColourSelector, ISquarePositionCalculator squarePositionCalculator, ISquareOriginCalculator squareOriginCalculator, ISquareDepthCalculator squareDepthCalculator)
        {
            _tileTextureFactory = tileTextureFactory;
            _squareColourSelector = squareColourSelector;
            _squarePositionCalculator = squarePositionCalculator;
            _squareOriginCalculator = squareOriginCalculator;
            _squareDepthCalculator = squareDepthCalculator;
        }

        protected override void DrawImp(SpriteBatch spriteBatch, Square square)
        {
            var tileTextureCreator = _tileTextureFactory.Create(square.Tile);

            var texture = tileTextureCreator.Create(square.Tile);
            var colour = _squareColourSelector.SelectColour(square);
            var position = _squarePositionCalculator.Calculate();
            var origin = _squareOriginCalculator.Calculate(square.XPos, square.YPos);
            var layerDepth = _squareDepthCalculator.Calculate(square);
            
            spriteBatch.Draw(texture, position, null, colour, MathHelper.ToRadians(square.Angle), origin,
                             new Vector2(1f, 1f), SpriteEffects.None, layerDepth);
            
     
        }
    }
}