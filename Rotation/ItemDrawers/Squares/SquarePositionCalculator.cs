using Microsoft.Xna.Framework;
using Rotation.Constants;
using Rotation.Engine;
using Rotation.StandardBoard;

namespace Rotation.ItemDrawers.Squares
{
    public class SquarePositionCalculator : ISquarePositionCalculator
    {

        private readonly IGetMainSelectedSquare _getMainSelectedSquare;

        public SquarePositionCalculator(IGetMainSelectedSquare getMainSelectedSquare)
        {
            _getMainSelectedSquare = getMainSelectedSquare;
        }


        public Vector2 Calculate()
        {
            var square = _getMainSelectedSquare.GetMainSelectedSquare();

            var x = ((square.X * DrawingConstants.Tiles.TILE_WIDTH) + (DrawingConstants.Tiles.TILE_WIDTH/2) + DrawingConstants.Board.BOARD_X_MARGIN);
            var y = ((square.Y * DrawingConstants.Tiles.TILE_HEIGHT) + (DrawingConstants.Tiles.TILE_HEIGHT / 2) + DrawingConstants.Board.BOARD_Y_MARGIN);

            return new Vector2(x, y);
        }
    }
}