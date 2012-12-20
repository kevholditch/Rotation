using Microsoft.Xna.Framework;
using Rotation.ItemDrawers.Squares;
using Rotation.StandardBoard;
using SubSpec;

namespace Rotation.GameObjects.sTests.DrawingSpecs
{
    public class SquareOriginCalculatorSpecs
    {
        [Specification]
        public void CanCorrectlyCalculateOriginForTopLeftSquareWhenCentreSquareSelected()
        {
            var result = default(Vector2);
            var board = default(IBoard);
            var squareOriginCalculator = default(SquareOriginCalculator);

            "Given I have a standard board with the centre square selected".Context(() =>
                {
                    board = new BoardFactory().Create();
                    squareOriginCalculator = new SquareOriginCalculator(board);
                    board[4, 4].IsMainSelection = true;
                });

            "When I calculate the origin for square 0, 0".Do(
                () => result = squareOriginCalculator.Calculate(board[0, 0]));

            "Then the origin x should be 180".Observation(() => result.X.ShouldEqual(180));

            "Then the origin y should be 180".Observation(() => result.Y.ShouldEqual(180));
        }

        [Specification]
        public void CanCorrectlyCalculateOriginForBottomRightSquareWhenCentreSquareSelected()
        {
            var result = default(Vector2);
            var board = default(IBoard);
            var squareOriginCalculator = default(SquareOriginCalculator);

            "Given I have a standard board with the centre square selected".Context(() =>
            {
                board = new BoardFactory().Create();
                squareOriginCalculator = new SquareOriginCalculator(board);
                board[4, 4].IsMainSelection = true;
            });

            "When I calculate the origin for square 8, 8".Do(
                () => result = squareOriginCalculator.Calculate(board[8, 8]));

            "Then the origin x should be -140".Observation(() => result.X.ShouldEqual(-140));

            "Then the origin y should be -140".Observation(() => result.Y.ShouldEqual(-140));
        }

        [Specification]
        public void CanCorrectlyCalculateOriginForTopLeftSquareWhenSquareTwoOne()
        {
            var result = default(Vector2);
            var board = default(IBoard);
            var squareOriginCalculator = default(SquareOriginCalculator);

            "Given I have a standard board with the centre square selected".Context(() =>
            {
                board = new BoardFactory().Create();
                squareOriginCalculator = new SquareOriginCalculator(board);
                board[2, 1].IsMainSelection = true;
            });

            "When I calculate the origin for square 0, 0".Do(
                () => result = squareOriginCalculator.Calculate(board[0, 0]));

            "Then the origin x should be 100".Observation(() => result.X.ShouldEqual(100));

            "Then the origin y should be 60".Observation(() => result.Y.ShouldEqual(60));
        }

        [Specification]
        public void CanCorrectlyCalculateOriginForBottomRightSquareWhenSquareTwoOne()
        {
            var result = default(Vector2);
            var board = default(IBoard);
            var squareOriginCalculator = default(SquareOriginCalculator);

            "Given I have a standard board with the centre square selected".Context(() =>
            {
                board = new BoardFactory().Create();
                squareOriginCalculator = new SquareOriginCalculator(board);
                board[2, 1].IsMainSelection = true;
            });

            "When I calculate the origin for square 8, 8".Do(
                () => result = squareOriginCalculator.Calculate(board[8, 8]));

            "Then the origin x should be -220".Observation(() => result.X.ShouldEqual(-220));

            "Then the origin y should be -260".Observation(() => result.Y.ShouldEqual(-260));
        }

        [Specification]
        public void CanCorrectlyCalculateTheOriginOfASquareWithAYOffset()
        {
            var result = default(Vector2);
            var board = default(IBoard);
            var squareOriginCalculator = default(SquareOriginCalculator);

            "Given I a y offset on square 0, 0".Context(() =>
            {
                board = new BoardFactory().Create();
                squareOriginCalculator = new SquareOriginCalculator(board);
                board[4, 4].IsMainSelection = true;
                board[0, 0].YOffset = 20;
            });

            "When I calculate the origin for square 0, 0".Do(
                () => result = squareOriginCalculator.Calculate(board[0, 0]));

            "Then the origin x should be 180".Observation(() => result.X.ShouldEqual(180));

            "Then the origin y should be 200".Observation(() => result.Y.ShouldEqual(200));
        }
    }
}
