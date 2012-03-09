using Rotation.GameObjects.Board;
using SubSpec;
using System.Linq;

namespace Xunit.BoardSpecs
{
	public class BoardCreationSpecs
	{
		private Board _board = null;
		private BoardFactory _boardFactory = null;


		[Specification]
		public void BoardFactoryCanCreateAStandardGrid()
		{
			"Given that I have a standard board factory".Context(() => _boardFactory = new BoardFactory());

			"When I create a board".Do(() => _board = _boardFactory.Create());

			"Then the board should have 9 rows".Observation(() => _board.Rows.Count.ShouldEqual(9));

			"Then the board should have 9 columns".Observation(() => _board.Columns.Count.ShouldEqual(9));

			"Then row 1 should have 1 square".Observation(() => _board.Rows[0].Squares.Count.ShouldEqual(1));

			"Then row 2 should have 3 squares".Observation(() => _board.Rows[1].Squares.Count.ShouldEqual(3));

			"Then row 3 should have 5 squares".Observation(() => _board.Rows[2].Squares.Count.ShouldEqual(5));

			"Then row 4 should have 7 squares".Observation(() => _board.Rows[3].Squares.Count.ShouldEqual(7));

			"Then row 5 should have 9 squares".Observation(() => _board.Rows[4].Squares.Count.ShouldEqual(9));

			"Then row 6 should have 7 squares".Observation(() => _board.Rows[5].Squares.Count.ShouldEqual(7));

			"Then row 7 should have 5 squares".Observation(() => _board.Rows[6].Squares.Count.ShouldEqual(5));

			"Then row 8 should have 3 squares".Observation(() => _board.Rows[7].Squares.Count.ShouldEqual(3));

			"Then row 9 should have 1 squares".Observation(() => _board.Rows[8].Squares.Count.ShouldEqual(1));			

			"Then column 1 should have 1 square".Observation(() => _board.Columns[0].Squares.Count.ShouldEqual(1));

			"Then column 2 should have 3 squares".Observation(() => _board.Columns[1].Squares.Count.ShouldEqual(3));

			"Then column 3 should have 5 squares".Observation(() => _board.Columns[2].Squares.Count.ShouldEqual(5));

			"Then column 4 should have 7 squares".Observation(() => _board.Columns[3].Squares.Count.ShouldEqual(7));

			"Then column 5 should have 9 squares".Observation(() => _board.Columns[4].Squares.Count.ShouldEqual(9));

			"Then column 6 should have 7 squares".Observation(() => _board.Columns[5].Squares.Count.ShouldEqual(7));

			"Then column 7 should have 5 squares".Observation(() => _board.Columns[6].Squares.Count.ShouldEqual(5));

			"Then column 8 should have 3 squares".Observation(() => _board.Columns[7].Squares.Count.ShouldEqual(3));

			"Then column 9 should have 1 squares".Observation(() => _board.Columns[8].Squares.Count.ShouldEqual(1));

		}

		[Specification]
		public void CheckThatTheRowsAndColumnsShareSquares()
		{
			"Given that I have a standard board factory".Context(() => _boardFactory = new BoardFactory());

			"When I create a board".Do(() => _board = _boardFactory.Create());

			"Then the 1st square in the 1st row should be the same as the 1st square in the 5th column".Observation(
				() => _board.Rows[0].Squares[0].ShouldBeTheSameAs(_board.Columns[4].Squares[0]));

			"Then the 1st square in the 2nd row should be the same as the 1st square in the 4th column".Observation(
				() => _board.Rows[1].Squares[0].ShouldBeTheSameAs(_board.Columns[3].Squares[0]));

			"Then the 1st square in the 3rd row should be the same as the 1st square in the 3rd column".Observation(
				() => _board.Rows[2].Squares[0].ShouldBeTheSameAs(_board.Columns[2].Squares[0]));

			"Then the 1st square in the 4th row should be the same as the 1st square in the 2nd column".Observation(
				() => _board.Rows[3].Squares[0].ShouldBeTheSameAs(_board.Columns[1].Squares[0]));

			"Then the 1st square in the 5th row should be the same as the 1st square in the 1st column".Observation(
				() => _board.Rows[4].Squares[0].ShouldBeTheSameAs(_board.Columns[0].Squares[0]));

			"Then the 1st square in the 6th row should be the same as the 3rd square in the 2nd column".Observation(
				() => _board.Rows[5].Squares[0].ShouldBeTheSameAs(_board.Columns[1].Squares[2]));

			"Then the 1st square in the 7th row should be the same as the 5th square in the 3rd column".Observation(
				() => _board.Rows[6].Squares[0].ShouldBeTheSameAs(_board.Columns[2].Squares[4]));

			"Then the 1st square in the 8th row should be the same as the 7th square in the 4th column".Observation(
				() => _board.Rows[7].Squares[0].ShouldBeTheSameAs(_board.Columns[3].Squares[6]));

			"Then the 1st square in the 9th row should be the same as the 9th square in the 5th column".Observation(
				() => _board.Rows[8].Squares[0].ShouldBeTheSameAs(_board.Columns[4].Squares[8]));

			"Then the last square in the 2nd row should be the same as the 1st square in the 6th column".Observation(
				() => _board.Rows[1].Squares[2].ShouldBeTheSameAs(_board.Columns[5].Squares[0]));

			"Then the last square in the 3rd row should be the same as the 1st square in the 7th column".Observation(
				() => _board.Rows[2].Squares[4].ShouldBeTheSameAs(_board.Columns[6].Squares[0]));

			"Then the last square in the 4th row should be the same as the 1st square in the 8th column".Observation(
				() => _board.Rows[3].Squares[6].ShouldBeTheSameAs(_board.Columns[7].Squares[0]));

			"Then the last square in the 5th row should be the same as the 1st square in the 9th column".Observation(
				() => _board.Rows[4].Squares[8].ShouldBeTheSameAs(_board.Columns[8].Squares[0]));

			"Then the last square in the 6th row should be the same as the last square in the 8th column".Observation(
				() => _board.Rows[5].Squares[6].ShouldBeTheSameAs(_board.Columns[7].Squares[2]));

			"Then the last square in the 7th row should be the same as the last square in the 7th column".Observation(
				() => _board.Rows[6].Squares[4].ShouldBeTheSameAs(_board.Columns[6].Squares[4]));

			"Then the last square in the 8th row should be the same as the last square in the 6th column".Observation(
				() => _board.Rows[7].Squares[2].ShouldBeTheSameAs(_board.Columns[5].Squares[6]));

			"Then the last square in the 9th row should be the same as the last square in the 5th column".Observation(
				() => _board.Rows[8].Squares[0].ShouldBeTheSameAs(_board.Columns[4].Squares[8]));
		}

		[Specification]
		public void BoardFactorySetsCorrectSquaresAsSelectable()
		{
			"Given that I have a board factory".Context(
				() => _boardFactory = new BoardFactory());

			"When I create a new board".Do(() => _board = _boardFactory.Create());

			"Then the first square in every row should not be selectable".Observation(() =>
			                                                                          	{
																							foreach (Line r in _board.Rows)
																								r.Squares[0].IsSelectable.ShouldBeFalse();
			                                                                          	});


			"Then the last square in every row should not be selectable".Observation(() =>
			                                                                         	{
																							foreach(Line r in _board.Rows)
																								r.Squares[r.Squares.Count-1].IsSelectable.ShouldBeFalse();
			                                                                         	});

			"Then each square that is not the first or last square in every row should be selectable".Observation(() =>
			                                                                                         	{
			                                                                                         		foreach (var r in _board.Rows)			                                                                                         		
			                                                                                         			for (var i = 1; i < r.Squares.Count - 1; i++)			                                                                                         			
			                                                                                         				r.Squares[i].IsSelectable.ShouldBeTrue();
			                                                                                         						                                                                                         		
			                                                                                         	});
			
		}
	}
}