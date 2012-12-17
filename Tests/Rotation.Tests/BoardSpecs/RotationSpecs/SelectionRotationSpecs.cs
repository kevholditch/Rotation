using Rotation.Events;
using Rotation.GameObjects.sTests.TestClasses;
using Rotation.StandardBoard;
using Rotation.StandardBoard.Rotation;
using Rotation.StandardBoard.Selection;
using SubSpec;

namespace Rotation.GameObjects.sTests.BoardSpecs.RotationSpecs
{
	public class SelectionRotationSpecs
	{
		[Specification]
		public void LettersAreCorrectWhenASelectionIsRotatedRight()
		{
            var selectionRotator = new SelectionRotatator();
            var board = default(Board);
            var squareSelector = new SquareSelector();

            "Given that I have a board filled numerically and I have selected the centre square".Context(() =>
                {
                    GameEvents.Dispatcher =
                        new ActionEventDispatcher
                            (a => { });
                    board = new BoardFactory().Create();
                    new NumericalBoardFiller().Fill(board);
                    squareSelector.Select(board, 4, 4);
                });

		    "When I rotate the board right".Do(() => selectionRotator.Right(board));

		    "Then square 4, 0 will contain colour 17".Observation(() => board[4, 0].Colour.ShouldEqual(17));

		    "Then square 3, 1 will contain colour 2".Observation(() => board[3, 1].Colour.ShouldEqual(2));

		    "Then square 4, 1 will contain colour 18".Observation(() => board[4, 1].Colour.ShouldEqual(18));

		    "Then square 5, 1 will contain colour 4".Observation(() => board[5, 1].Colour.ShouldEqual(4));

		    "Then square 2, 2 will contain colour 5".Observation(() => board[2, 2].Colour.ShouldEqual(5));

		    "Then square 3, 2 will contain colour 6".Observation(() => board[3, 2].Colour.ShouldEqual(6));

		    "Then square 4, 2 will contain colour 19".Observation(() => board[4, 2].Colour.ShouldEqual(19));

		    "Then square 5, 2 will contain colour 8".Observation(() => board[5, 2].Colour.ShouldEqual(8));

		    "Then square 6, 2 will contain colour 9".Observation(() => board[6, 2].Colour.ShouldEqual(9));

		    "Then square 1, 3 will contain colour 10".Observation(() => board[1, 3].Colour.ShouldEqual(10));

		    "Then square 2, 3 will contain colour 11".Observation(() => board[2, 3].Colour.ShouldEqual(11));

		    "Then square 3, 3 will contain colour 12".Observation(() => board[3, 3].Colour.ShouldEqual(12));

		    "Then square 4, 3 will contain colour 20".Observation(() => board[4, 3].Colour.ShouldEqual(20));

		    "Then square 5, 3 will contain colour 14".Observation(() => board[5, 3].Colour.ShouldEqual(14));

		    "Then square 6, 3 will contain colour 15".Observation(() => board[6, 3].Colour.ShouldEqual(15));

		    "Then square 7, 3 will contain colour 16".Observation(() => board[7, 3].Colour.ShouldEqual(16));

		    "Then square 0, 4 will contain colour 41".Observation(() => board[0, 4].Colour.ShouldEqual(41));

		    "Then square 1, 4 will contain colour 39".Observation(() => board[1, 4].Colour.ShouldEqual(39));

		    "Then square 2, 4 will contain colour 35".Observation(() => board[2, 4].Colour.ShouldEqual(35));

		    "Then square 3, 4 will contain colour 29".Observation(() => board[3, 4].Colour.ShouldEqual(29));

		    "Then square 4, 4 will contain colour 21".Observation(() => board[4, 4].Colour.ShouldEqual(21));

		    "Then square 5, 4 will contain colour 13".Observation(() => board[5, 4].Colour.ShouldEqual(13));

		    "Then square 6, 4 will contain colour 7".Observation(() => board[6, 4].Colour.ShouldEqual(7));

		    "Then square 7, 4 will contain colour 3".Observation(() => board[7, 4].Colour.ShouldEqual(3));

		    "Then square 8, 4 will contain colour 1".Observation(() => board[8, 4].Colour.ShouldEqual(1));

		    "Then square 1, 5 will contain colour 26".Observation(() => board[1, 5].Colour.ShouldEqual(26));

		    "Then square 2, 5 will contain colour 27".Observation(() => board[2, 5].Colour.ShouldEqual(27));

		    "Then square 3, 5 will contain colour 28".Observation(() => board[3, 5].Colour.ShouldEqual(28));

		    "Then square 4, 5 will contain colour 22".Observation(() => board[4, 5].Colour.ShouldEqual(22));

		    "Then square 5, 5 will contain colour 30".Observation(() => board[5, 5].Colour.ShouldEqual(30));

		    "Then square 6, 5 will contain colour 31".Observation(() => board[6, 5].Colour.ShouldEqual(31));

		    "Then square 7, 5 will contain colour 32".Observation(() => board[7, 5].Colour.ShouldEqual(32));

		    "Then square 2, 6 will contain colour 33".Observation(() => board[2, 6].Colour.ShouldEqual(33));

		    "Then square 3, 6 will contain colour 34".Observation(() => board[3, 6].Colour.ShouldEqual(34));

		    "Then square 4, 6 will contain colour 23".Observation(() => board[4, 6].Colour.ShouldEqual(23));

		    "Then square 5, 6 will contain colour 36".Observation(() => board[5, 6].Colour.ShouldEqual(36));

		    "Then square 6, 6 will contain colour 37".Observation(() => board[6, 6].Colour.ShouldEqual(37));

		    "Then square 3, 7 will contain colour 38".Observation(() => board[3, 7].Colour.ShouldEqual(38));

		    "Then square 4, 7 will contain colour 24".Observation(() => board[4, 7].Colour.ShouldEqual(24));

		    "Then square 5, 7 will contain colour 40".Observation(() => board[5, 7].Colour.ShouldEqual(40));

		    "Then square 4, 8 will contain colour 25".Observation(() => board[4, 8].Colour.ShouldEqual(25));

		}

       
		[Specification]
		public void LettersAreCorrectWhenIRotateASmallSelectionRight()
		{
		    var selectionRotator = new SelectionRotatator();
            var board = default(Board);
            var squareSelector = new SquareSelector();

            "Given that I have a board filled alphabetically and I have selected square 5, 2".Context(() =>
                {
                    GameEvents.Dispatcher =
                        new ActionEventDispatcher
                            (a => { });
                    board = new BoardFactory().Create();
                    new NumericalBoardFiller().Fill(board);
                    squareSelector.Select(board, 5, 2);
                });

            "When I rotate the board right".Do(() => selectionRotator.Right(board));

		    "Then square 4, 1 will contain colour 3".Observation(() => board[4, 1].Colour.ShouldEqual(3));

		    "Then square 5, 1 will contain colour 7".Observation(() => board[5, 1].Colour.ShouldEqual(7));

		    "Then square 4, 2 will contain colour 14".Observation(() => board[4, 2].Colour.ShouldEqual(14));

		    "Then square 5, 2 will contain colour 8".Observation(() => board[5, 2].Colour.ShouldEqual(8));

		    "Then square 4, 3 will contain colour 13".Observation(() => board[4, 3].Colour.ShouldEqual(13));

		    "Then square 5, 3 will contain colour 9".Observation(() => board[5, 3].Colour.ShouldEqual(9));

		    "Then square 6, 3 will contain colour 15".Observation(() => board[6, 3].Colour.ShouldEqual(15));

		    "Then square 7, 3 will contain colour 16".Observation(() => board[7, 3].Colour.ShouldEqual(16));

		}

       
		[Specification]
		public void LettersAreCorrectWhenIRotateASelectionLeft()
		{
            var selectionRotator = new SelectionRotatator();
            var board = default(Board);
            var squareSelector = new SquareSelector();

            "Given that I have a board filled alphabetically and I have selected the centre square".Context(() =>
            {
                GameEvents.Dispatcher = new ActionEventDispatcher(a => { });
                board = new BoardFactory().Create();
                new NumericalBoardFiller().Fill(board);
                squareSelector.Select(board, 4, 4);
            });

		    "When I rotate the board left".Do(() => selectionRotator.Left(board));

		    "Then square 4, 0 will contain colour 25".Observation(() => board[4, 0].Colour.ShouldEqual(25));

		    "Then square 3, 1 will contain colour 2".Observation(() => board[3, 1].Colour.ShouldEqual(2));

		    "Then square 4, 1 will contain colour 24".Observation(() => board[4, 1].Colour.ShouldEqual(24));

		    "Then square 5, 1 will contain colour 4".Observation(() => board[5, 1].Colour.ShouldEqual(4));

		    "Then square 2, 2 will contain colour 5".Observation(() => board[2, 2].Colour.ShouldEqual(5));

		    "Then square 3, 2 will contain colour 6".Observation(() => board[3, 2].Colour.ShouldEqual(6));

		    "Then square 4, 2 will contain colour 23".Observation(() => board[4, 2].Colour.ShouldEqual(23));

		    "Then square 5, 2 will contain colour 8".Observation(() => board[5, 2].Colour.ShouldEqual(8));

		    "Then square 6, 2 will contain colour 9".Observation(() => board[6, 2].Colour.ShouldEqual(9));

		    "Then square 1, 3 will contain colour 10".Observation(() => board[1, 3].Colour.ShouldEqual(10));

		    "Then square 2, 3 will contain colour 11".Observation(() => board[2, 3].Colour.ShouldEqual(11));

		    "Then square 3, 3 will contain colour 12".Observation(() => board[3, 3].Colour.ShouldEqual(12));

		    "Then square 4, 3 will contain colour 22".Observation(() => board[4, 3].Colour.ShouldEqual(22));

		    "Then square 5, 3 will contain colour 14".Observation(() => board[5, 3].Colour.ShouldEqual(14));

		    "Then square 6, 3 will contain colour 15".Observation(() => board[6, 3].Colour.ShouldEqual(15));

		    "Then square 7, 3 will contain colour 16".Observation(() => board[7, 3].Colour.ShouldEqual(16));

		    "Then square 0, 4 will contain colour 1".Observation(() => board[0, 4].Colour.ShouldEqual(1));

		    "Then square 1, 4 will contain colour 3".Observation(() => board[1, 4].Colour.ShouldEqual(3));

		    "Then square 2, 4 will contain colour 7".Observation(() => board[2, 4].Colour.ShouldEqual(7));

		    "Then square 3, 4 will contain colour 13".Observation(() => board[3, 4].Colour.ShouldEqual(13));

		    "Then square 4, 4 will contain colour 21".Observation(() => board[4, 4].Colour.ShouldEqual(21));

		    "Then square 5, 4 will contain colour 29".Observation(() => board[5, 4].Colour.ShouldEqual(29));

		    "Then square 6, 4 will contain colour 35".Observation(() => board[6, 4].Colour.ShouldEqual(35));

		    "Then square 7, 4 will contain colour 39".Observation(() => board[7, 4].Colour.ShouldEqual(39));

		    "Then square 8, 4 will contain colour 41".Observation(() => board[8, 4].Colour.ShouldEqual(41));

		    "Then square 1, 5 will contain colour 26".Observation(() => board[1, 5].Colour.ShouldEqual(26));

		    "Then square 2, 5 will contain colour 27".Observation(() => board[2, 5].Colour.ShouldEqual(27));

		    "Then square 3, 5 will contain colour 28".Observation(() => board[3, 5].Colour.ShouldEqual(28));

		    "Then square 4, 5 will contain colour 20".Observation(() => board[4, 5].Colour.ShouldEqual(20));

		    "Then square 5, 5 will contain colour 30".Observation(() => board[5, 5].Colour.ShouldEqual(30));

		    "Then square 6, 5 will contain colour 31".Observation(() => board[6, 5].Colour.ShouldEqual(31));

		    "Then square 7, 5 will contain colour 32".Observation(() => board[7, 5].Colour.ShouldEqual(32));

		    "Then square 2, 6 will contain colour 33".Observation(() => board[2, 6].Colour.ShouldEqual(33));

		    "Then square 3, 6 will contain colour 34".Observation(() => board[3, 6].Colour.ShouldEqual(34));

		    "Then square 4, 6 will contain colour 19".Observation(() => board[4, 6].Colour.ShouldEqual(19));

		    "Then square 5, 6 will contain colour 36".Observation(() => board[5, 6].Colour.ShouldEqual(36));

		    "Then square 6, 6 will contain colour 37".Observation(() => board[6, 6].Colour.ShouldEqual(37));

		    "Then square 3, 7 will contain colour 38".Observation(() => board[3, 7].Colour.ShouldEqual(38));

		    "Then square 4, 7 will contain colour 18".Observation(() => board[4, 7].Colour.ShouldEqual(18));

		    "Then square 5, 7 will contain colour 40".Observation(() => board[5, 7].Colour.ShouldEqual(40));

		    "Then square 4, 8 will contain colour 17".Observation(() => board[4, 8].Colour.ShouldEqual(17));

		}

        
		[Specification]
		public void LettersAreCorrectWhenIRotateASmallSelectionLeft()
		{
		    var selectionRotator = new SelectionRotatator();
		    var board = default(Board);
		    var squareSelector = new SquareSelector();

		    "Given that I have a board filled alphabetically and I have selected the square 5, 2".Context(() =>
		            {
		                GameEvents.Dispatcher = new ActionEventDispatcher(a => {});
		                board = new BoardFactory().Create();
		                new NumericalBoardFiller().Fill(board);
		                squareSelector.Select(board,5, 2);
		            });

		    "When I rotate the board left".Do(() => selectionRotator.Left(board));

		    "Then square 4, 1 will contain colour 3".Observation(() => board[4, 1].Colour.ShouldEqual(3));

		    "Then square 5, 1 will contain colour 9".Observation(() => board[5, 1].Colour.ShouldEqual(9));

		    "Then square 4, 2 will contain colour 4".Observation(() => board[4, 2].Colour.ShouldEqual(4));

		    "Then square 5, 2 will contain colour 8".Observation(() => board[5, 2].Colour.ShouldEqual(8));

		    "Then square 4, 3 will contain colour 13".Observation(() => board[4, 3].Colour.ShouldEqual(13));

		    "Then square 5, 3 will contain colour 7".Observation(() => board[5, 3].Colour.ShouldEqual(7));

		    "Then square 6, 3 will contain colour 15".Observation(() => board[6, 3].Colour.ShouldEqual(15));

		    "Then square 7, 3 will contain colour 16".Observation(() => board[7, 3].Colour.ShouldEqual(16));
		}

        
	}
}