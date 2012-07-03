using System;
using Microsoft.Xna.Framework;
using Rotation.GameObjects.StandardBoard;

namespace Rotation.Drawing.ItemDrawers.Squares
{
    public class SquareOriginCalculator : ISquareOriginCalculator
    {
        private readonly IGetMainSelectedSquare _getMainSelectedSquare;

        public SquareOriginCalculator(IGetMainSelectedSquare getMainSelectedSquare)
        {
            _getMainSelectedSquare = getMainSelectedSquare;
        }


        public Vector2 Calculate(int x, int y)
        {
            var mainSelectedSquare = _getMainSelectedSquare.GetMainSelectedSquare();

            var originX = -((x - mainSelectedSquare.X) - 0.5f)*DrawingConstants.Tiles.TILE_WIDTH;
            var originY = -((y - mainSelectedSquare.Y) - 0.5f)*DrawingConstants.Tiles.TILE_HEIGHT;

            return new Vector2(originX, originY);
        }
    }
}