using Microsoft.Xna.Framework;
using Rotation.Constants;
using Rotation.Engine;
using Rotation.ItemDrawers.Squares;
using Rotation.StandardBoard;
using SubSpec;

namespace Rotation.GameObjects.sTests.DrawingSpecs
{
    public class SquarePositionCalculatorSpecs
    {
        [Specification]
        public void CanCorrectlyObtainAllSquaresPositonsWhenCentreSquareSelected()
        {
            var squarePositionCalculator = default(SquarePositionCalculator);
            var result = default(Vector2);

            "Given I have a standard board and have selected the centre square".Context(() =>
                                        {
                                            var board = new BoardFactory().Create();
                                            board[4, 4].IsMainSelection = true;
                                            squarePositionCalculator = new SquarePositionCalculator(board);

                                        });

            "When I calculate the position for squares on the board".Do(
                () => result = squarePositionCalculator.Calculate());

            "Then the X position should be 180 + board X margin".Observation(
                () => result.X.ShouldEqual(180 + DrawingConstants.Board.BOARD_X_MARGIN));

            "Then the Y position should be 180 + board Y margin".Observation(
                () => result.Y.ShouldEqual(180 + DrawingConstants.Board.BOARD_Y_MARGIN));

        }

        [Specification]
        public void CanCorrectlyObtainAllSquaresPositonsWhenSquareTwoOneSelected()
        {
            var squarePositionCalculator = default(SquarePositionCalculator);
            var result = default(Vector2);

            "Given I have a standard board and have selected the centre square".Context(() =>
            {
                var board = new BoardFactory().Create();
                board[2, 1].IsMainSelection = true;
                squarePositionCalculator = new SquarePositionCalculator(board);

            });

            "When I calculate the position for squares on the board".Do(
                () => result = squarePositionCalculator.Calculate());

            "Then the X position should be 100 + board X margin".Observation(
                () => result.X.ShouldEqual(100 + DrawingConstants.Board.BOARD_X_MARGIN));

            "Then the Y position should be 60 + board Y margin".Observation(
                () => result.Y.ShouldEqual(60 + DrawingConstants.Board.BOARD_Y_MARGIN));

        }
    }
}
