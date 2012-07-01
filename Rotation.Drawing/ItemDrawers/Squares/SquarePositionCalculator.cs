using System;
using Microsoft.Xna.Framework;
using Rotation.GameObjects.StandardBoard;

namespace Rotation.Drawing.ItemDrawers.Squares
{
    public class SquarePositionCalculator : ISquarePositionCalculator
    {

        private readonly Func<BoardCoordinate> _getMainSelectedSquare;

        public SquarePositionCalculator(Func<BoardCoordinate> getMainSelectedSquare)
        {
            _getMainSelectedSquare = getMainSelectedSquare;
        }

        public Vector2 Calculate()
        {
            var square = _getMainSelectedSquare();

            var x = ((square.X * DrawingConstants.Tiles.TILE_WIDTH) + (DrawingConstants.Tiles.TILE_WIDTH/2) + DrawingConstants.Board.BOARD_X_MARGIN);
            var y = ((square.Y * DrawingConstants.Tiles.TILE_HEIGHT) + (DrawingConstants.Tiles.TILE_HEIGHT / 2) + DrawingConstants.Board.BOARD_Y_MARGIN);

            return new Vector2(x, y);
        }
    }
}