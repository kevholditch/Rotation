using Rotation.GameObjects.StandardBoard;
using Rotation.GameObjects.StandardBoard.Selection;
using Rotation.Tests.Common;
using SubSpec;
using System.Linq;

namespace Rotation.GameObjects.sTests.BoardSpecs.SelectionSpecs
{
	public class SelectingSquareSpecs
	{
		[Specification]
		public void CanSelectTheCentreSquareCorrectly()
		{
			SquareSelector squareSelector = default(SquareSelector);
			Board board = null;

			"Given I have a standard board with no squares selected and a square selector".Context(() =>
			                                                                                       	{
			                                                                                       		board =
			                                                                                       			new BoardFactory().Create();
			                                                                                       		squareSelector =
			                                                                                       			new SquareSelector();
			                                                                                       	});

			"When I select the centre square".Do(() => squareSelector.Select(board, 4, 4));

			"Then square 4, 4 should be the main selection".Observation(() => board[4, 4].IsMainSelection.ShouldBeTrue());

			"Then the square at position 4, 0 should be selected".Observation(() => board[4, 0].IsSelected.ShouldBeTrue());

			"Then the square at position 4, 1 should be selected".Observation(() => board[4, 1].IsSelected.ShouldBeTrue());

			"Then the square at position 4, 2 should be selected".Observation(() => board[4, 2].IsSelected.ShouldBeTrue());

			"Then the square at position 4, 3 should be selected".Observation(() => board[4, 3].IsSelected.ShouldBeTrue());

			"Then the square at position 4, 4 should be selected".Observation(() => board[4, 4].IsSelected.ShouldBeTrue());

			"Then the square at position 4, 5 should be selected".Observation(() => board[4, 5].IsSelected.ShouldBeTrue());

			"Then the square at position 4, 6 should be selected".Observation(() => board[4, 6].IsSelected.ShouldBeTrue());

			"Then the square at position 4, 7 should be selected".Observation(() => board[4, 7].IsSelected.ShouldBeTrue());

			"Then the square at position 4, 8 should be selected".Observation(() => board[4, 8].IsSelected.ShouldBeTrue());

			"Then the square at position 0, 4 should be selected".Observation(() => board[0, 4].IsSelected.ShouldBeTrue());

			"Then the square at position 0, 4 should be selected".Observation(() => board[0, 4].IsSelected.ShouldBeTrue());

			"Then the square at position 1, 4 should be selected".Observation(() => board[1, 4].IsSelected.ShouldBeTrue());

			"Then the square at position 2, 4 should be selected".Observation(() => board[2, 4].IsSelected.ShouldBeTrue());

			"Then the square at position 3, 4 should be selected".Observation(() => board[3, 4].IsSelected.ShouldBeTrue());

			"Then the square at position 5, 4 should be selected".Observation(() => board[5, 4].IsSelected.ShouldBeTrue());

			"Then the square at position 6, 4 should be selected".Observation(() => board[6, 4].IsSelected.ShouldBeTrue());

			"Then the square at position 7, 4 should be selected".Observation(() => board[7, 4].IsSelected.ShouldBeTrue());

			"Then the square at position 8, 4 should be selected".Observation(() => board[8, 4].IsSelected.ShouldBeTrue());

			"Then there should be a total of 17 selected squares".Observation(
				() => board.AllSquares().Count(sq => sq.IsSelected).ShouldEqual(17));
		}

		public void CanSelectSquareFourAcrossTwoDownCorrectly()
		{
			SquareSelector squareSelector = default(SquareSelector);
			Board board = null;

			"Given I have a standard board with no squares selected and a square selector".Context(() =>
			                                                                                       	{
			                                                                                       		board =
			                                                                                       			new BoardFactory().Create();
			                                                                                       		squareSelector =
			                                                                                       			new SquareSelector();
			                                                                                       	});

			"When I select the centre square 4,2".Do(() => squareSelector.Select(board, 4, 2));

			"Then square 4, 2 should be the main selection".Observation(() => board[4, 2].IsMainSelection.ShouldBeTrue());

			"Then the square at position 4, 0 should be selected".Observation(() => board[4, 0].IsSelected.ShouldBeTrue());

			"Then the square at position 4, 1 should be selected".Observation(() => board[4, 1].IsSelected.ShouldBeTrue());

			"Then the square at position 4, 2 should be selected".Observation(() => board[4, 2].IsSelected.ShouldBeTrue());

			"Then the square at position 4, 3 should be selected".Observation(() => board[4, 3].IsSelected.ShouldBeTrue());

			"Then the square at position 4, 4 should be selected".Observation(() => board[4, 4].IsSelected.ShouldBeTrue());
			
			"Then the square at position 2, 2 should be selected".Observation(() => board[2, 2].IsSelected.ShouldBeTrue());

			"Then the square at position 3, 2 should be selected".Observation(() => board[3, 2].IsSelected.ShouldBeTrue());
						
			"Then the square at position 5, 2 should be selected".Observation(() => board[5, 2].IsSelected.ShouldBeTrue());

			"Then the square at position 6, 2 should be selected".Observation(() => board[6, 2].IsSelected.ShouldBeTrue());

			"Then there should be a total of 9 selected squares".Observation(
				() => board.AllSquares().Count(sq => sq.IsSelected).ShouldEqual(9));
		}

		public void CanSelectSquareFiveAcrossSixDownCorrectly()
		{
			SquareSelector squareSelector = default(SquareSelector);
			Board board = null;

			"Given I have a standard board with no squares selected and a square selector".Context(() =>
			{
				board =
					new BoardFactory().Create();
				squareSelector =
					new SquareSelector();
			});

			"When I select the centre square 5, 6".Do(() => squareSelector.Select(board, 5, 6));

			"Then square 5, 6 should be the main selection".Observation(() => board[5, 6].IsMainSelection.ShouldBeTrue());

			"Then the square at position 5, 5 should be selected".Observation(() => board[5, 5].IsSelected.ShouldBeTrue());

			"Then the square at position 5, 6 should be selected".Observation(() => board[5, 6].IsSelected.ShouldBeTrue());

			"Then the square at position 5, 7 should be selected".Observation(() => board[5, 7].IsSelected.ShouldBeTrue());

			"Then the square at position 4, 6 should be selected".Observation(() => board[4, 6].IsSelected.ShouldBeTrue());

			"Then the square at position 6, 6 should be selected".Observation(() => board[6, 6].IsSelected.ShouldBeTrue());

			"Then there should be a total of 5 selected squares".Observation(
				() => board.AllSquares().Count(sq => sq.IsSelected).ShouldEqual(5));

		}
	}
}