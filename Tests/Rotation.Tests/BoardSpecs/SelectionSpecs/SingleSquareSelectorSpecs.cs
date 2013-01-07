using Rotation.StandardBoard;
using Rotation.StandardBoard.Selection;
using SubSpec;
using System.Linq;

namespace Rotation.GameObjects.sTests.BoardSpecs.SelectionSpecs
{
    public class SingleSquareSelectorSpecs
    {
        [Specification]
        public void CanSelectTheCentreSquareCorrectly()
        {
            var squareSelector = default(SingleSquareSelector);
            Board board = null;

            "Given I have a standard board with no squares selected and a single square selector".Context(() =>
                {
                    board =
                        new BoardFactory().Create();
                    squareSelector =
                        new SingleSquareSelector();
                });

            "When I select the centre square 4, 4".Do(() => squareSelector.Select(board, 4, 4));

            "Then square 4, 4 should be the main selection"
                .Observation(() => board[4, 4].IsMainSelection.ShouldBeTrue());

            "Then square 3, 4 should be selected"
                .Observation(() => board[3, 4].IsSelected.ShouldBeTrue());

            "Then square 5, 4 should be selected"
                .Observation(() => board[5, 4].IsSelected.ShouldBeTrue());

            "Then square 4, 3 should be selected"
                .Observation(() => board[4, 3].IsSelected.ShouldBeTrue());

            "Then square 4, 5 should be selected"
                .Observation(() => board[4, 5].IsSelected.ShouldBeTrue());

            "Then there should be a total of 5 squares selected"
                .Observation(() => board.AllSquares().Count(sq => sq.IsSelected).ShouldEqual(5));

        }

        [Specification]
        public void CanSelectSquareThreeTwoCorrectly()
        {
            var squareSelector = default(SingleSquareSelector);
            Board board = null;

            "Given I have a standard board with no squares selected and a single square selector".Context(() =>
            {
                board =
                    new BoardFactory().Create();
                squareSelector =
                    new SingleSquareSelector();
            });

            "When I select the centre square 2, 3".Do(() => squareSelector.Select(board, 2, 3));

            "Then square 2, 3 should be the main selection"
                .Observation(() => board[2, 3].IsMainSelection.ShouldBeTrue());

            "Then square 1, 3 should be selected"
                .Observation(() => board[1, 3].IsSelected.ShouldBeTrue());

            "Then square 3, 3 should be selected"
                .Observation(() => board[3, 3].IsSelected.ShouldBeTrue());

            "Then square 2, 2 should be selected"
                .Observation(() => board[2, 2].IsSelected.ShouldBeTrue());

            "Then square 2, 4 should be selected"
                .Observation(() => board[2, 4].IsSelected.ShouldBeTrue());

            "Then there should be a total of 5 squares selected"
                .Observation(() => board.AllSquares().Count(sq => sq.IsSelected).ShouldEqual(5));

        }
    }
}