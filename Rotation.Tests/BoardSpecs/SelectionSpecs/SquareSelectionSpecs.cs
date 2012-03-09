using System.Linq;
using Rotation.GameObjects.Board;
using Rotation.GameObjects.Board.Selection;
using SubSpec;

namespace Xunit.BoardSpecs.SelectionSpecs
{
	public class SquareSelectionSpecs
	{
		private BoardFactory _boardFactory;
		private Board _board;
		private BoardSquareSelector _boardSquareSelector;

		[Specification]
		public void CanSelectTheCentreSquare()
		{
			"Given that I have a board with no squares selected".Context(() =>
			                                                             	{
																				_boardFactory = new BoardFactory();
			                                                             		_boardSquareSelector = new BoardSquareSelector();
			                                                             		_board = _boardFactory.Create();
			                                                             	});

			"When I select the centre square".Do(() => _boardSquareSelector.SelectSquares(_board, 4, 4));

			"Then all of column 4 will be selected".Observation(() => _board.Columns[4].Squares.Any(s => !s.IsSelected).ShouldBeFalse());

			"Then all of row 4 will be selected".Observation(() => _board.Rows[4].Squares.Any(s => !s.IsSelected).ShouldBeFalse());

			"Then there will be a total of 16 squares selected".Observation(
				() => _board.AllSquares().Count(s => s.IsSelected).ShouldEqual(16));
		}

		[Specification]
		public void CanSelectTheSquareInColumnOneRowFour()
		{
			"Given that I have a board with no squares selected".Context(() =>
			{
				_boardFactory = new BoardFactory();
				_boardSquareSelector = new BoardSquareSelector();
				_board = _boardFactory.Create();
			});

			"When I select the square in column 1 row 4".Do(() => _boardSquareSelector.SelectSquares(_board, 1, 4));

			"Then all of column 1 will be selected".Observation(() => _board.Columns[1].Squares.Any(s => !s.IsSelected).ShouldBeFalse());

			"Then square 0 of row 4 will be selected".Observation(() => _board.Rows[4].Squares[0].IsSelected.ShouldBeTrue());

			"Then square 1 of row 4 will be selected".Observation(() => _board.Rows[4].Squares[1].IsSelected.ShouldBeTrue());

			"Then square 2 of row 4 will be selected".Observation(() => _board.Rows[4].Squares[2].IsSelected.ShouldBeTrue());

			"Then there will be a total of 4 squares selected".Observation(
				() => _board.AllSquares().Count(s => s.IsSelected).ShouldEqual(4));
		}

		[Specification]
		public void CanSelectTheSquareInColumnFiveRowThree()
		{
			"Given that I have a board with no squares selected".Context(() =>
			{
				_boardFactory = new BoardFactory();
				_boardSquareSelector = new BoardSquareSelector();
				_board = _boardFactory.Create();
			});

			"When I select the square in column 5 row 3".Do(() => _boardSquareSelector.SelectSquares(_board, 5, 3));

			"Then the 1st square in column 5 will be selected".Observation(() => _board.Columns[4].Squares[0].IsSelected.ShouldBeTrue());

			"Then the 2nd square in column 5 will be selected".Observation(() => _board.Columns[4].Squares[1].IsSelected.ShouldBeTrue());

			"Then the 3rd square in column 5 will be selected".Observation(() => _board.Columns[4].Squares[2].IsSelected.ShouldBeTrue());

			"Then the 4th square in column 5 will be selected".Observation(() => _board.Columns[4].Squares[3].IsSelected.ShouldBeTrue());

			"Then the 5th square in column 5 will be selected".Observation(() => _board.Columns[4].Squares[4].IsSelected.ShouldBeTrue());

			"Then the 3rd square in the 4th row will be selected".Observation(() => _board.Rows[3].Squares[2].IsSelected.ShouldBeTrue());

			"Then the 4th square in the 4th row will be selected".Observation(() => _board.Rows[3].Squares[3].IsSelected.ShouldBeTrue());

			"Then the 5th square in the 4th row will be selected".Observation(() => _board.Rows[3].Squares[4].IsSelected.ShouldBeTrue());

			"Then the 6th square in the 4th row will be selected".Observation(() => _board.Rows[3].Squares[5].IsSelected.ShouldBeTrue());

			"Then the 7th square in the 4th row will be selected".Observation(() => _board.Rows[3].Squares[6].IsSelected.ShouldBeTrue());

			"Then there will be a total of 9 squares selected".Observation(
				() => _board.AllSquares().Count(s => s.IsSelected).ShouldEqual(9));
		}
	}
}