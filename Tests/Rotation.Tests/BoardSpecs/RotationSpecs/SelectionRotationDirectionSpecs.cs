using Rotation.GameObjects.Drawing;
using Rotation.GameObjects.Events;
using Rotation.GameObjects.StandardBoard;
using Rotation.GameObjects.StandardBoard.Rotation;
using Rotation.GameObjects.StandardBoard.Selection;
using Rotation.GameObjects.sTests.TestClasses;
using Rotation.Tests.Common;
using SubSpec;

namespace Rotation.GameObjects.sTests.BoardSpecs.RotationSpecs
{
	public class SelectionRotationDirectionSpecs
	{
		
        [Specification]
        public void RotationDirectionsAreCorrectWhenASelectionIsRotatedRight()
        {
            var selectionRotator = new SelectionRotatator();
            var board = default(Board);
            var squareSelector = new SquareSelector();

            "Given that I have a board filled alphabetically and I have selected the centre square".Context(() =>
                {
                    GameEvents.Dispatcher =
                        new ActionEventDispatcher
                            (a => { });
                    board = new BoardFactory().Create();
                    new AlphabeticalBoardFiller().Fill(board);
                    squareSelector.Select(board, 4, 4);
                });

            "When I rotate the board right".Do(() => selectionRotator.Right(board));

            "Then square 4, 0 will have a rotation direction of clockwise".Observation(
                () => board[4, 0].Direction.ShouldEqual(RotationDirection.Clockwise));

            "Then square 3, 1 will have a rotation direction of none".Observation(
                () => board[3, 1].Direction.ShouldEqual(RotationDirection.None));

            "Then square 4, 1 will have a rotation direction of clockwise".Observation(
                () => board[4, 1].Direction.ShouldEqual(RotationDirection.Clockwise));

            "Then square 5, 1 will have a rotation direction of none".Observation(
                () => board[5, 1].Direction.ShouldEqual(RotationDirection.None));

            "Then square 2, 2 will have a rotation direction of none".Observation(
                () => board[2, 2].Direction.ShouldEqual(RotationDirection.None));

            "Then square 3, 2 will have a rotation direction of none".Observation(
                () => board[3, 2].Direction.ShouldEqual(RotationDirection.None));

            "Then square 4, 2 will have a rotation direction of clockwise".Observation(
                () => board[4, 2].Direction.ShouldEqual(RotationDirection.Clockwise));

            "Then square 5, 2 will have a rotation direction of none".Observation(
                () => board[5, 2].Direction.ShouldEqual(RotationDirection.None));

            "Then square 6, 2 will have a rotation direction of none".Observation(
                () => board[6, 2].Direction.ShouldEqual(RotationDirection.None));

            "Then square 1, 3 will have a rotation direction of none".Observation(
                () => board[1, 3].Direction.ShouldEqual(RotationDirection.None));

            "Then square 2, 3 will have a rotation direction of none".Observation(
                () => board[2, 3].Direction.ShouldEqual(RotationDirection.None));

            "Then square 3, 3 will have a rotation direction of none".Observation(
                () => board[3, 3].Direction.ShouldEqual(RotationDirection.None));

            "Then square 4, 3 will have a rotation direction of clockwise".Observation(
                () => board[4, 3].Direction.ShouldEqual(RotationDirection.Clockwise));

            "Then square 5, 3 will have a rotation direction of none".Observation(
                () => board[5, 3].Direction.ShouldEqual(RotationDirection.None));

            "Then square 6, 3 will have a rotation direction of none".Observation(
                () => board[6, 3].Direction.ShouldEqual(RotationDirection.None));

            "Then square 7, 3 will have a rotation direction of none".Observation(
                () => board[7, 3].Direction.ShouldEqual(RotationDirection.None));

            "Then square 0, 4 will have a rotation direction of clockwise".Observation(
                () => board[0, 4].Direction.ShouldEqual(RotationDirection.Clockwise));

            "Then square 1, 4 will have a rotation direction of clockwise".Observation(
                () => board[1, 4].Direction.ShouldEqual(RotationDirection.Clockwise));

            "Then square 2, 4 will have a rotation direction of clockwise".Observation(
                () => board[2, 4].Direction.ShouldEqual(RotationDirection.Clockwise));

            "Then square 3, 4 will have a rotation direction of clockwise".Observation(
                () => board[3, 4].Direction.ShouldEqual(RotationDirection.Clockwise));

            "Then square 4, 4 will have a rotation direction of none".Observation(
                () => board[4, 4].Direction.ShouldEqual(RotationDirection.None));

            "Then square 5, 4 will have a rotation direction of clockwise".Observation(
                () => board[5, 4].Direction.ShouldEqual(RotationDirection.Clockwise));

            "Then square 6, 4 will have a rotation direction of clockwise".Observation(
                () => board[6, 4].Direction.ShouldEqual(RotationDirection.Clockwise));

            "Then square 7, 4 will have a rotation direction of clockwise".Observation(
                () => board[7, 4].Direction.ShouldEqual(RotationDirection.Clockwise));

            "Then square 8, 4 will have a rotation direction of clockwise".Observation(
                () => board[8, 4].Direction.ShouldEqual(RotationDirection.Clockwise));

            "Then square 1, 5 will have a rotation direction of none".Observation(
                () => board[1, 5].Direction.ShouldEqual(RotationDirection.None));

            "Then square 2, 5 will have a rotation direction of none".Observation(
                () => board[2, 5].Direction.ShouldEqual(RotationDirection.None));

            "Then square 3, 5 will have a rotation direction of none".Observation(
                () => board[3, 5].Direction.ShouldEqual(RotationDirection.None));

            "Then square 4, 5 will have a rotation direction of clockwise".Observation(
                () => board[4, 5].Direction.ShouldEqual(RotationDirection.Clockwise));

            "Then square 5, 5 will have a rotation direction of none".Observation(
                () => board[5, 5].Direction.ShouldEqual(RotationDirection.None));

            "Then square 6, 5 will have a rotation direction of none".Observation(
                () => board[6, 5].Direction.ShouldEqual(RotationDirection.None));

            "Then square 7, 5 will have a rotation direction of none".Observation(
                () => board[7, 5].Direction.ShouldEqual(RotationDirection.None));

            "Then square 2, 6 will have a rotation direction of none".Observation(
                () => board[2, 6].Direction.ShouldEqual(RotationDirection.None));

            "Then square 3, 6 will have a rotation direction of none".Observation(
                () => board[3, 6].Direction.ShouldEqual(RotationDirection.None));

            "Then square 4, 6 will have a rotation direction of clockwise".Observation(
                () => board[4, 6].Direction.ShouldEqual(RotationDirection.Clockwise));

            "Then square 5, 6 will have a rotation direction of none".Observation(
                () => board[5, 6].Direction.ShouldEqual(RotationDirection.None));

            "Then square 6, 6 will have a rotation direction of none".Observation(
                () => board[6, 6].Direction.ShouldEqual(RotationDirection.None));

            "Then square 3, 7 will have a rotation direction of none".Observation(
                () => board[3, 7].Direction.ShouldEqual(RotationDirection.None));

            "Then square 4, 7 will have a rotation direction of clockwise".Observation(
                () => board[4, 7].Direction.ShouldEqual(RotationDirection.Clockwise));

            "Then square 5, 7 will have a rotation direction of none".Observation(
                () => board[5, 7].Direction.ShouldEqual(RotationDirection.None));

            "Then square 4, 8 will have a rotation direction of clockwise".Observation(
                () => board[4, 8].Direction.ShouldEqual(RotationDirection.Clockwise));

        }

        
       
		
        [Specification]
        public void DirectionsAreCorrectWhenIRotateASelectionLeft()
        {
            var selectionRotator = new SelectionRotatator();
            var board = default(Board);
            var squareSelector = new SquareSelector();

            "Given that I have a board filled alphabetically and I have selected the centre square".Context(() =>
            {
                GameEvents.Dispatcher = new ActionEventDispatcher(a => { });
                board = new BoardFactory().Create();
                new AlphabeticalBoardFiller().Fill(board);
                squareSelector.Select(board, 4, 4);
            });

            "When I rotate the board left".Do(() => selectionRotator.Left(board));

            "Then square 4, 0 will have a rotation direction of anti-clockwise".Observation(
                () => board[4, 0].Direction.ShouldEqual(RotationDirection.AntiClockwise));

            "Then square 3, 1 will have a rotation direction of none".Observation(
                () => board[3, 1].Direction.ShouldEqual(RotationDirection.None));

            "Then square 4, 1 will have a rotation direction of anti-clockwise".Observation(
                () => board[4, 1].Direction.ShouldEqual(RotationDirection.AntiClockwise));

            "Then square 5, 1 will have a rotation direction of none".Observation(
                () => board[5, 1].Direction.ShouldEqual(RotationDirection.None));

            "Then square 2, 2 will have a rotation direction of none".Observation(
                () => board[2, 2].Direction.ShouldEqual(RotationDirection.None));

            "Then square 3, 2 will have a rotation direction of none".Observation(
                () => board[3, 2].Direction.ShouldEqual(RotationDirection.None));

            "Then square 4, 2 will have a rotation direction of anti-clockwise".Observation(
                () => board[4, 2].Direction.ShouldEqual(RotationDirection.AntiClockwise));

            "Then square 5, 2 will have a rotation direction of none".Observation(
                () => board[5, 2].Direction.ShouldEqual(RotationDirection.None));

            "Then square 6, 2 will have a rotation direction of none".Observation(
                () => board[6, 2].Direction.ShouldEqual(RotationDirection.None));

            "Then square 1, 3 will have a rotation direction of none".Observation(
                () => board[1, 3].Direction.ShouldEqual(RotationDirection.None));

            "Then square 2, 3 will have a rotation direction of none".Observation(
                () => board[2, 3].Direction.ShouldEqual(RotationDirection.None));

            "Then square 3, 3 will have a rotation direction of none".Observation(
                () => board[3, 3].Direction.ShouldEqual(RotationDirection.None));

            "Then square 4, 3 will have a rotation direction of anti-clockwise".Observation(
                () => board[4, 3].Direction.ShouldEqual(RotationDirection.AntiClockwise));

            "Then square 5, 3 will have a rotation direction of none".Observation(
                () => board[5, 3].Direction.ShouldEqual(RotationDirection.None));

            "Then square 6, 3 will have a rotation direction of none".Observation(
                () => board[6, 3].Direction.ShouldEqual(RotationDirection.None));

            "Then square 7, 3 will have a rotation direction of none".Observation(
                () => board[7, 3].Direction.ShouldEqual(RotationDirection.None));

            "Then square 0, 4 will have a rotation direction of anti-clockwise".Observation(
                () => board[0, 4].Direction.ShouldEqual(RotationDirection.AntiClockwise));

            "Then square 1, 4 will have a rotation direction of anti-clockwise".Observation(
                () => board[1, 4].Direction.ShouldEqual(RotationDirection.AntiClockwise));

            "Then square 2, 4 will have a rotation direction of anti-clockwise".Observation(
                () => board[2, 4].Direction.ShouldEqual(RotationDirection.AntiClockwise));

            "Then square 3, 4 will have a rotation direction of anti-clockwise".Observation(
                () => board[3, 4].Direction.ShouldEqual(RotationDirection.AntiClockwise));

            "Then square 4, 4 will have a rotation direction of none".Observation(
                () => board[4, 4].Direction.ShouldEqual(RotationDirection.None));

            "Then square 5, 4 will have a rotation direction of anti-clockwise".Observation(
                () => board[5, 4].Direction.ShouldEqual(RotationDirection.AntiClockwise));

            "Then square 6, 4 will have a rotation direction of anti-clockwise".Observation(
                () => board[6, 4].Direction.ShouldEqual(RotationDirection.AntiClockwise));

            "Then square 7, 4 will have a rotation direction of anti-clockwise".Observation(
                () => board[7, 4].Direction.ShouldEqual(RotationDirection.AntiClockwise));

            "Then square 8, 4 will have a rotation direction of anti-clockwise".Observation(
                () => board[8, 4].Direction.ShouldEqual(RotationDirection.AntiClockwise));

            "Then square 1, 5 will have a rotation direction of none".Observation(
                () => board[1, 5].Direction.ShouldEqual(RotationDirection.None));

            "Then square 2, 5 will have a rotation direction of none".Observation(
                () => board[2, 5].Direction.ShouldEqual(RotationDirection.None));

            "Then square 3, 5 will have a rotation direction of none".Observation(
                () => board[3, 5].Direction.ShouldEqual(RotationDirection.None));

            "Then square 4, 5 will have a rotation direction of anti-clockwise".Observation(
                () => board[4, 5].Direction.ShouldEqual(RotationDirection.AntiClockwise));

            "Then square 5, 5 will have a rotation direction of none".Observation(
                () => board[5, 5].Direction.ShouldEqual(RotationDirection.None));

            "Then square 6, 5 will have a rotation direction of none".Observation(
                () => board[6, 5].Direction.ShouldEqual(RotationDirection.None));

            "Then square 7, 5 will have a rotation direction of none".Observation(
                () => board[7, 5].Direction.ShouldEqual(RotationDirection.None));

            "Then square 2, 6 will have a rotation direction of none".Observation(
                () => board[2, 6].Direction.ShouldEqual(RotationDirection.None));

            "Then square 3, 6 will have a rotation direction of none".Observation(
                () => board[3, 6].Direction.ShouldEqual(RotationDirection.None));

            "Then square 4, 6 will have a rotation direction of anti-clockwise".Observation(
                () => board[4, 6].Direction.ShouldEqual(RotationDirection.AntiClockwise));

            "Then square 5, 6 will have a rotation direction of none".Observation(
                () => board[5, 6].Direction.ShouldEqual(RotationDirection.None));

            "Then square 6, 6 will have a rotation direction of none".Observation(
                () => board[6, 6].Direction.ShouldEqual(RotationDirection.None));

            "Then square 3, 7 will have a rotation direction of none".Observation(
                () => board[3, 7].Direction.ShouldEqual(RotationDirection.None));

            "Then square 4, 7 will have a rotation direction of anti-clockwise".Observation(
                () => board[4, 7].Direction.ShouldEqual(RotationDirection.AntiClockwise));

            "Then square 5, 7 will have a rotation direction of none".Observation(
                () => board[5, 7].Direction.ShouldEqual(RotationDirection.None));

            "Then square 4, 8 will have a rotation direction of anti-clockwise".Observation(
                () => board[4, 8].Direction.ShouldEqual(RotationDirection.AntiClockwise));

        }

        
	}
}