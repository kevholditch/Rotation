using Rotation.GameObjects.Events;
using Rotation.GameObjects.StandardBoard;
using Rotation.GameObjects.StandardBoard.Rotation;
using Rotation.GameObjects.StandardBoard.Selection;
using Rotation.GameObjects.sTests.TestClasses;
using Rotation.Tests.Common;
using SubSpec;

namespace Rotation.GameObjects.sTests.BoardSpecs.RotationSpecs
{
	public class SelectionRotationAngleSpecs
	{

        [Specification]
        public void RotationAnglesAreCorrectWhenASelectionIsRotatedRight()
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

	        "Then square 4, 0 will have an angle of -90".Observation(() => board[4, 0].Angle.ShouldEqual(-90));

            "Then square 3, 1 will have an angle of 0".Observation(() => board[3, 1].Angle.ShouldEqual(0));

            "Then square 4, 1 will have an angle of -90".Observation(() => board[4, 1].Angle.ShouldEqual(-90));

            "Then square 5, 1 will have an angle of 0".Observation(() => board[5, 1].Angle.ShouldEqual(0));

            "Then square 2, 2 will have an angle of 0".Observation(() => board[2, 2].Angle.ShouldEqual(0));

            "Then square 3, 2 will have an angle of 0".Observation(() => board[3, 2].Angle.ShouldEqual(0));

            "Then square 4, 2 will have an angle of -90".Observation(() => board[4, 2].Angle.ShouldEqual(-90));

            "Then square 5, 2 will have an angle of 0".Observation(() => board[5, 2].Angle.ShouldEqual(0));

            "Then square 6, 2 will have an angle of 0".Observation(() => board[6, 2].Angle.ShouldEqual(0));

            "Then square 1, 3 will have an angle of 0".Observation(() => board[1, 3].Angle.ShouldEqual(0));

            "Then square 2, 3 will have an angle of 0".Observation(() => board[2, 3].Angle.ShouldEqual(0));

            "Then square 3, 3 will have an angle of 0".Observation(() => board[3, 3].Angle.ShouldEqual(0));

            "Then square 4, 3 will have an angle of -90".Observation(() => board[4, 3].Angle.ShouldEqual(-90));

            "Then square 5, 3 will have an angle of 0".Observation(() => board[5, 3].Angle.ShouldEqual(0));

            "Then square 6, 3 will have an angle of 0".Observation(() => board[6, 3].Angle.ShouldEqual(0));

            "Then square 7, 3 will have an angle of 0".Observation(() => board[7, 3].Angle.ShouldEqual(0));

            "Then square 0, 4 will have an angle of -90".Observation(() => board[0, 4].Angle.ShouldEqual(-90));

            "Then square 1, 4 will have an angle of -90".Observation(() => board[1, 4].Angle.ShouldEqual(-90));

            "Then square 2, 4 will have an angle of -90".Observation(() => board[2, 4].Angle.ShouldEqual(-90));

            "Then square 3, 4 will have an angle of -90".Observation(() => board[3, 4].Angle.ShouldEqual(-90));

            "Then square 4, 4 will have an angle of 0".Observation(() => board[4, 4].Angle.ShouldEqual(0));

            "Then square 5, 4 will have an angle of -90".Observation(() => board[5, 4].Angle.ShouldEqual(-90));

            "Then square 6, 4 will have an angle of -90".Observation(() => board[6, 4].Angle.ShouldEqual(-90));

            "Then square 7, 4 will have an angle of -90".Observation(() => board[7, 4].Angle.ShouldEqual(-90));

            "Then square 8, 4 will have an angle of -90".Observation(() => board[8, 4].Angle.ShouldEqual(-90));

            "Then square 1, 5 will have an angle of 0".Observation(() => board[1, 5].Angle.ShouldEqual(0));

            "Then square 2, 5 will have an angle of 0".Observation(() => board[2, 5].Angle.ShouldEqual(0));

            "Then square 3, 5 will have an angle of 0".Observation(() => board[3, 5].Angle.ShouldEqual(0));

            "Then square 4, 5 will have an angle of -90".Observation(() => board[4, 5].Angle.ShouldEqual(-90));

            "Then square 5, 5 will have an angle of 0".Observation(() => board[5, 5].Angle.ShouldEqual(0));

            "Then square 6, 5 will have an angle of 0".Observation(() => board[6, 5].Angle.ShouldEqual(0));

            "Then square 7, 5 will have an angle of 0".Observation(() => board[7, 5].Angle.ShouldEqual(0));

            "Then square 2, 6 will have an angle of 0".Observation(() => board[2, 6].Angle.ShouldEqual(0));

            "Then square 3, 6 will have an angle of 0".Observation(() => board[3, 6].Angle.ShouldEqual(0));

            "Then square 4, 6 will have an angle of -90".Observation(() => board[4, 6].Angle.ShouldEqual(-90));

            "Then square 5, 6 will have an angle of 0".Observation(() => board[5, 6].Angle.ShouldEqual(0));

            "Then square 6, 6 will have an angle of 0".Observation(() => board[6, 6].Angle.ShouldEqual(0));

            "Then square 3, 7 will have an angle of 0".Observation(() => board[3, 7].Angle.ShouldEqual(0));

            "Then square 4, 7 will have an angle of -90".Observation(() => board[4, 7].Angle.ShouldEqual(-90));

            "Then square 5, 7 will have an angle of 0".Observation(() => board[5, 7].Angle.ShouldEqual(0));

            "Then square 4, 8 will have an angle of -90".Observation(() => board[4, 8].Angle.ShouldEqual(-90));
		}

		
        [Specification]
        public void AnglesAreCorrectWhenIRotateASelectionLeft()
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

	        "Then square 4, 0 will have an angle of 90".Observation(() => board[4, 0].Angle.ShouldEqual(90));

            "Then square 3, 1 will have an angle of 0".Observation(() => board[3, 1].Angle.ShouldEqual(0));

            "Then square 4, 1 will have an angle of 90".Observation(() => board[4, 1].Angle.ShouldEqual(90));

            "Then square 5, 1 will have an angle of 0".Observation(() => board[5, 1].Angle.ShouldEqual(0));

            "Then square 2, 2 will have an angle of 0".Observation(() => board[2, 2].Angle.ShouldEqual(0));

            "Then square 3, 2 will have an angle of 0".Observation(() => board[3, 2].Angle.ShouldEqual(0));

            "Then square 4, 2 will have an angle of 90".Observation(() => board[4, 2].Angle.ShouldEqual(90));

            "Then square 5, 2 will have an angle of 0".Observation(() => board[5, 2].Angle.ShouldEqual(0));

            "Then square 6, 2 will have an angle of 0".Observation(() => board[6, 2].Angle.ShouldEqual(0));

            "Then square 1, 3 will have an angle of 0".Observation(() => board[1, 3].Angle.ShouldEqual(0));

            "Then square 2, 3 will have an angle of 0".Observation(() => board[2, 3].Angle.ShouldEqual(0));

            "Then square 3, 3 will have an angle of 0".Observation(() => board[3, 3].Angle.ShouldEqual(0));

            "Then square 4, 3 will have an angle of 90".Observation(() => board[4, 3].Angle.ShouldEqual(90));

            "Then square 5, 3 will have an angle of 0".Observation(() => board[5, 3].Angle.ShouldEqual(0));

            "Then square 6, 3 will have an angle of 0".Observation(() => board[6, 3].Angle.ShouldEqual(0));

            "Then square 7, 3 will have an angle of 0".Observation(() => board[7, 3].Angle.ShouldEqual(0));

            "Then square 0, 4 will have an angle of 90".Observation(() => board[0, 4].Angle.ShouldEqual(90));

            "Then square 1, 4 will have an angle of 90".Observation(() => board[1, 4].Angle.ShouldEqual(90));

            "Then square 2, 4 will have an angle of 90".Observation(() => board[2, 4].Angle.ShouldEqual(90));

            "Then square 3, 4 will have an angle of 90".Observation(() => board[3, 4].Angle.ShouldEqual(90));

            "Then square 4, 4 will have an angle of 0".Observation(() => board[4, 4].Angle.ShouldEqual(0));

            "Then square 5, 4 will have an angle of 90".Observation(() => board[5, 4].Angle.ShouldEqual(90));

            "Then square 6, 4 will have an angle of 90".Observation(() => board[6, 4].Angle.ShouldEqual(90));

            "Then square 7, 4 will have an angle of 90".Observation(() => board[7, 4].Angle.ShouldEqual(90));

            "Then square 8, 4 will have an angle of 90".Observation(() => board[8, 4].Angle.ShouldEqual(90));

            "Then square 1, 5 will have an angle of 0".Observation(() => board[1, 5].Angle.ShouldEqual(0));

            "Then square 2, 5 will have an angle of 0".Observation(() => board[2, 5].Angle.ShouldEqual(0));

            "Then square 3, 5 will have an angle of 0".Observation(() => board[3, 5].Angle.ShouldEqual(0));

            "Then square 4, 5 will have an angle of 90".Observation(() => board[4, 5].Angle.ShouldEqual(90));

            "Then square 5, 5 will have an angle of 0".Observation(() => board[5, 5].Angle.ShouldEqual(0));

            "Then square 6, 5 will have an angle of 0".Observation(() => board[6, 5].Angle.ShouldEqual(0));

            "Then square 7, 5 will have an angle of 0".Observation(() => board[7, 5].Angle.ShouldEqual(0));

            "Then square 2, 6 will have an angle of 0".Observation(() => board[2, 6].Angle.ShouldEqual(0));

            "Then square 3, 6 will have an angle of 0".Observation(() => board[3, 6].Angle.ShouldEqual(0));

            "Then square 4, 6 will have an angle of 90".Observation(() => board[4, 6].Angle.ShouldEqual(90));

            "Then square 5, 6 will have an angle of 0".Observation(() => board[5, 6].Angle.ShouldEqual(0));

            "Then square 6, 6 will have an angle of 0".Observation(() => board[6, 6].Angle.ShouldEqual(0));

            "Then square 3, 7 will have an angle of 0".Observation(() => board[3, 7].Angle.ShouldEqual(0));

            "Then square 4, 7 will have an angle of 90".Observation(() => board[4, 7].Angle.ShouldEqual(90));

            "Then square 5, 7 will have an angle of 0".Observation(() => board[5, 7].Angle.ShouldEqual(0));

            "Then square 4, 8 will have an angle of 90".Observation(() => board[4, 8].Angle.ShouldEqual(90));
		}
        
	}
}