using Rotation.StandardBoard;
using Rotation.StandardBoard.Selection;
using SubSpec;

namespace Rotation.GameObjects.sTests.BoardSpecs.SelectionSpecs
{
    public class SquareSelectableSpecs
    {
        [Specification]
        public void CanSelectAnInBoundsSelectableSquare()
        {
            var board = default(IBoard);
            var squareSelectable = default(SquareSelectable);
            var result = default(bool);

            "Given I have a default 9x9 board".Context(() =>
                            {
                                board = new BoardFactory().Create();
                                squareSelectable = new SquareSelectable();
                            });

            "When I try to select a square in bounds that is selectable".Do(() =>
                result = squareSelectable.CanSelectSquare(board, 3, 3));

            "Then that square should be selectable".Observation(() =>
                result.ShouldBeTrue());
        }

        [Specification]
        public void CannotSelectAnInBoundsUnSelectableSquare()
        {
            var board = default(IBoard);
            var squareSelectable = default(SquareSelectable);
            var result = default(bool);

            "Given I have a default 9x9 board".Context(() =>
            {
                board = new BoardFactory().Create();
                squareSelectable = new SquareSelectable();
            });

            "When I try to select a square in bounds that is not selectable".Do(() =>
                result = squareSelectable.CanSelectSquare(board, 0, 3));

            "Then that square should not be selectable".Observation(() =>
                result.ShouldBeFalse());
        }

        [Specification]
        public void CannotSelectASquareOutOfLeftBounds()
        {
            var board = default(IBoard);
            var squareSelectable = default(SquareSelectable);
            var result = default(bool);

            "Given I have a default 9x9 board".Context(() =>
            {
                board = new BoardFactory().Create();
                squareSelectable = new SquareSelectable();
            });

            "When I try to select a square out of bounds to the left".Do(() =>
                result = squareSelectable.CanSelectSquare(board, -1, 3));

            "Then that square should not be selectable".Observation(() =>
                result.ShouldBeFalse());
        }

        [Specification]
        public void CannotSelectASquareOutOfRightBounds()
        {
            var board = default(IBoard);
            var squareSelectable = default(SquareSelectable);
            var result = default(bool);

            "Given I have a default 9x9 board".Context(() =>
            {
                board = new BoardFactory().Create();
                squareSelectable = new SquareSelectable();
            });

            "When I try to select a square out of bounds to the right".Do(() =>
                result = squareSelectable.CanSelectSquare(board, 100, 3));

            "Then that square should not be selectable".Observation(() =>
                result.ShouldBeFalse());
        }

        [Specification]
        public void CannotSelectASquareOutOfTopBounds()
        {
            var board = default(IBoard);
            var squareSelectable = default(SquareSelectable);
            var result = default(bool);

            "Given I have a default 9x9 board".Context(() =>
            {
                board = new BoardFactory().Create();
                squareSelectable = new SquareSelectable();
            });

            "When I try to select a square out of bounds at the top".Do(() =>
                result = squareSelectable.CanSelectSquare(board, 3, -1));

            "Then that square should not be selectable".Observation(() =>
                result.ShouldBeFalse());
        }

        [Specification]
        public void CannotSelectASquareOutOfBottomBounds()
        {
            var board = default(IBoard);
            var squareSelectable = default(SquareSelectable);
            var result = default(bool);

            "Given I have a default 9x9 board".Context(() =>
            {
                board = new BoardFactory().Create();
                squareSelectable = new SquareSelectable();
            });

            "When I try to select a square out of bounds at the bottom".Do(() =>
                result = squareSelectable.CanSelectSquare(board, 3, 100));

            "Then that square should not be selectable".Observation(() =>
                result.ShouldBeFalse());
        }
    }
}