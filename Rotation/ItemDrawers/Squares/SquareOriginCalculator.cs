using Microsoft.Xna.Framework;
using Rotation.Constants;
using Rotation.StandardBoard;

namespace Rotation.ItemDrawers.Squares
{
    public class SquareOriginCalculator : ISquareOriginCalculator
    {
        private readonly IGetMainSelectedSquare _getMainSelectedSquare;

        public SquareOriginCalculator(IGetMainSelectedSquare getMainSelectedSquare)
        {
            _getMainSelectedSquare = getMainSelectedSquare;
        }


        public Vector2 Calculate(Square square)
        {
            var mainSelectedSquare = _getMainSelectedSquare.GetMainSelectedSquare();

            var originX = -((square.XPos - mainSelectedSquare.X) - 0.5f)*DrawingConstants.Tiles.TILE_WIDTH;
            var originY = -((square.YPos - mainSelectedSquare.Y) - 0.5f)*DrawingConstants.Tiles.TILE_HEIGHT + square.YOffset;

            return new Vector2(originX, originY);
        }
    }
}