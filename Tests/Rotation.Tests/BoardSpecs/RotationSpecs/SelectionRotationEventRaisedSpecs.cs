using Rotation.Events;
using Rotation.GameObjects.sTests.TestClasses;
using Rotation.StandardBoard;
using Rotation.StandardBoard.Rotation;
using Rotation.StandardBoard.Selection;
using SubSpec;
using System.Linq;

namespace Rotation.GameObjects.sTests.BoardSpecs.RotationSpecs
{
    public class SelectionRotationEventRaisedSpecs
    {
        [Specification]
        public void RotatedLeftEventIsRaisedWhenIRotateASelectionLeft()
        {
            var selectionRotator = new SelectionRotatator();
            var board = default(Board);
            var squareSelector = new SquareSelector();
            var result = default(RotatedLeftEvent);

            "Given that I have a board filled alphabetically and I have selected the centre square".Context(() =>
            {
                GameEvents.Dispatcher = new ActionEventDispatcher(a => result = a as RotatedLeftEvent);
                board = new BoardFactory().Create();
                new NumericalBoardFiller().Fill(board);
                squareSelector.Select(board, 4, 4);
            });

            "When I rotate the board left".Do(() => selectionRotator.Left(board));

            "Then a rotated left event should be raised".Observation(() => result.ShouldNotBeNull());

            "Then 16 squares should be in the event".Observation(() => result.BoardCoordinates.Count().ShouldEqual(16));

        }

        [Specification]
        public void RotatedRightEventIsRaisedWhenIRotateASelectionRight()
        {
            var selectionRotator = new SelectionRotatator();
            var board = default(Board);
            var squareSelector = new SquareSelector();
            var result = default(RotatedRightEvent);

            "Given that I have a board filled alphabetically and I have selected the centre square".Context(() =>
            {
                GameEvents.Dispatcher = new ActionEventDispatcher(a => result = a as RotatedRightEvent);
                board = new BoardFactory().Create();
                new NumericalBoardFiller().Fill(board);
                squareSelector.Select(board, 4, 4);
            });

            "When I rotate the board right".Do(() => selectionRotator.Right(board));

            "Then a rotated right event should be raised".Observation(() => result.ShouldNotBeNull());

            "Then 16 squares should be in the event".Observation(() => result.BoardCoordinates.Count().ShouldEqual(16));

        }
    }
}