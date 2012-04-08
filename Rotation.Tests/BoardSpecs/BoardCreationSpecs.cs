using Rotation.GameObjects.Board;
using SubSpec;
using System.Linq;

namespace Xunit.BoardSpecs
{
	public class BoardCreationSpecs
	{
		
		[Specification]
		public void BoardFactoryShouldCreate9By9Board()
		{
			Board board = null;
			BoardFactory boardFactory = null;

			"Given that I have a standard board factory".Context(() => boardFactory = new BoardFactory());

			"When I create a board".Do(() => board = boardFactory.Create());

			"Then the board should have 9 rows".Observation(() => board.Rows.Count.ShouldEqual(9));

			"Then the board should have 9 columns".Observation(() => board.Columns.Count.ShouldEqual(9));			
		}

		[Specification]
		public void BoardFactoryShouldHaveSelectableSquaresInTheCorrectPositions()
		{
			Board board = null;
			BoardFactory boardFactory = null;

			"Given that I have a standard board factory".Context(() => boardFactory = new BoardFactory());

			"When I create a board".Do(() => board = boardFactory.Create());

			"Then row 0 should have one selectable square".Observation(
				() => board.Rows[0].Squares.Count(sq => sq.IsSelectable).ShouldEqual(1));

			"Then the square at index 4 on row 0 should be selectable".Observation(
				() => board.Rows[0].Squares[4].IsSelectable.ShouldBeTrue());

			"Then row 1 should have 3 selectable squares".Observation(
				() => board.Rows[1].Squares.Count(sq => sq.IsSelectable).ShouldEqual(3));

			"Then the square at index 3 on row 1 should be selectable".Observation(
				() => board.Rows[1].Squares[3].IsSelectable.ShouldBeTrue());

			"Then the square at index 4 on row 1 should be selectable".Observation(
				() => board.Rows[1].Squares[3].IsSelectable.ShouldBeTrue());

			"Then the square at index 5 on row 1 should be selectable".Observation(
				() => board.Rows[1].Squares[3].IsSelectable.ShouldBeTrue());

			"Then row 2 should have 5 selectable squares".Observation(
				() => board.Rows[2].Squares.Count(sq => sq.IsSelectable).ShouldEqual(5));

			"Then the square at index 2 on row 2 should be selectable".Observation(
				() => board.Rows[2].Squares[2].IsSelectable.ShouldBeTrue());

			"Then the square at index 3 on row 2 should be selectable".Observation(
				() => board.Rows[2].Squares[3].IsSelectable.ShouldBeTrue());

			"Then the square at index 4 on row 1 should be selectable".Observation(
				() => board.Rows[2].Squares[4].IsSelectable.ShouldBeTrue());

			"Then the square at index 5 on row 2 should be selectable".Observation(
				() => board.Rows[2].Squares[5].IsSelectable.ShouldBeTrue());

			"Then the square at index 6 on row 1 should be selectable".Observation(
				() => board.Rows[2].Squares[6].IsSelectable.ShouldBeTrue());

			"Then row 3 should have 7 selectable squares".Observation(
				() => board.Rows[3].Squares.Count(sq => sq.IsSelectable).ShouldEqual(7));

			"Then the square at index 1 on row 3 should be selectable".Observation(
				() => board.Rows[3].Squares[1].IsSelectable.ShouldBeTrue());

			"Then the square at index 2 on row 3 should be selectable".Observation(
				() => board.Rows[3].Squares[2].IsSelectable.ShouldBeTrue());

			"Then the square at index 3 on row 3 should be selectable".Observation(
				() => board.Rows[3].Squares[3].IsSelectable.ShouldBeTrue());

			"Then the square at index 4 on row 3 should be selectable".Observation(
				() => board.Rows[3].Squares[4].IsSelectable.ShouldBeTrue());

			"Then the square at index 5 on row 3 should be selectable".Observation(
				() => board.Rows[3].Squares[5].IsSelectable.ShouldBeTrue());

			"Then the square at index 6 on row 3 should be selectable".Observation(
				() => board.Rows[3].Squares[6].IsSelectable.ShouldBeTrue());

			"Then the square at index 7 on row 3 should be selectable".Observation(
				() => board.Rows[3].Squares[7].IsSelectable.ShouldBeTrue());

			"Then row 4 should have 9 selectable squares".Observation(
				() => board.Rows[4].Squares.Count(sq => sq.IsSelectable).ShouldEqual(9));

			"Then the square at index 0 on row 4 should be selectable".Observation(
				() => board.Rows[4].Squares[0].IsSelectable.ShouldBeTrue());

			"Then the square at index 1 on row 4 should be selectable".Observation(
				() => board.Rows[4].Squares[1].IsSelectable.ShouldBeTrue());

			"Then the square at index 2 on row 4 should be selectable".Observation(
				() => board.Rows[4].Squares[4].IsSelectable.ShouldBeTrue());

			"Then the square at index 3 on row 4 should be selectable".Observation(
				() => board.Rows[4].Squares[3].IsSelectable.ShouldBeTrue());

			"Then the square at index 4 on row 4 should be selectable".Observation(
				() => board.Rows[4].Squares[4].IsSelectable.ShouldBeTrue());

			"Then the square at index 5 on row 4 should be selectable".Observation(
				() => board.Rows[4].Squares[5].IsSelectable.ShouldBeTrue());

			"Then the square at index 6 on row 4 should be selectable".Observation(
				() => board.Rows[4].Squares[6].IsSelectable.ShouldBeTrue());

			"Then the square at index 7 on row 4 should be selectable".Observation(
				() => board.Rows[4].Squares[7].IsSelectable.ShouldBeTrue());

			"Then the square at index 8 on row 4 should be selectable".Observation(
				() => board.Rows[4].Squares[8].IsSelectable.ShouldBeTrue());

			"Then row 5 should have 7 selectable squares".Observation(
				() => board.Rows[5].Squares.Count(sq => sq.IsSelectable).ShouldEqual(7));

			"Then the square at index 1 on row 5 should be selectable".Observation(
				() => board.Rows[5].Squares[1].IsSelectable.ShouldBeTrue());

			"Then the square at index 2 on row 5 should be selectable".Observation(
				() => board.Rows[5].Squares[2].IsSelectable.ShouldBeTrue());

			"Then the square at index 3 on row 5 should be selectable".Observation(
				() => board.Rows[5].Squares[3].IsSelectable.ShouldBeTrue());

			"Then the square at index 4 on row 5 should be selectable".Observation(
				() => board.Rows[5].Squares[4].IsSelectable.ShouldBeTrue());

			"Then the square at index 5 on row 5 should be selectable".Observation(
				() => board.Rows[5].Squares[5].IsSelectable.ShouldBeTrue());

			"Then the square at index 6 on row 5 should be selectable".Observation(
				() => board.Rows[5].Squares[6].IsSelectable.ShouldBeTrue());

			"Then the square at index 7 on row 5 should be selectable".Observation(
				() => board.Rows[5].Squares[7].IsSelectable.ShouldBeTrue());

			"Then row 6 should have 5 selectable squares".Observation(
				() => board.Rows[6].Squares.Count(sq => sq.IsSelectable).ShouldEqual(5));

			"Then the square at index 2 on row 6 should be selectable".Observation(
				() => board.Rows[6].Squares[2].IsSelectable.ShouldBeTrue());

			"Then the square at index 3 on row 6 should be selectable".Observation(
				() => board.Rows[6].Squares[3].IsSelectable.ShouldBeTrue());

			"Then the square at index 4 on row 6 should be selectable".Observation(
				() => board.Rows[6].Squares[4].IsSelectable.ShouldBeTrue());

			"Then the square at index 5 on row 6 should be selectable".Observation(
				() => board.Rows[6].Squares[5].IsSelectable.ShouldBeTrue());

			"Then the square at index 6 on row 6 should be selectable".Observation(
				() => board.Rows[6].Squares[6].IsSelectable.ShouldBeTrue());

			"Then row 7 should have 3 selectable squares".Observation(
				() => board.Rows[7].Squares.Count(sq => sq.IsSelectable).ShouldEqual(3));

			"Then the square at index 7 on row 1 should be selectable".Observation(
				() => board.Rows[7].Squares[3].IsSelectable.ShouldBeTrue());

			"Then the square at index 7 on row 1 should be selectable".Observation(
				() => board.Rows[7].Squares[3].IsSelectable.ShouldBeTrue());

			"Then the square at index 7 on row 1 should be selectable".Observation(
				() => board.Rows[7].Squares[3].IsSelectable.ShouldBeTrue());

			"Then row 8 should have one selectable square".Observation(
				() => board.Rows[8].Squares.Count(sq => sq.IsSelectable).ShouldEqual(1));

			"Then the square at index 4 on row 8 should be selectable".Observation(
				() => board.Rows[8].Squares[4].IsSelectable.ShouldBeTrue());
		}

		[Specification]
		public void TheSquaresInTheRowsAndColumnsShouldPointToTheSameReference()
		{
			Board board = null;
			BoardFactory boardFactory = null;

			"Given that I have a standard board factory".Context(() => boardFactory = new BoardFactory());

			"When I create a board".Do(() => board = boardFactory.Create());

			"Then each columns square should have the same reference as its corresponding row".Observation(() =>
			                {
			                    for (int i = 0;
			                            i <
			                            board.Columns.
			                            Count;
			                            i++)
			                    {
									for (int j = 0; j < board.Rows.Count; j++)
									{
										board.Columns[i].Squares[j].ShouldBeTheSameAs(board.Rows[j].Squares[i]);
									}

			                    }
			                });
		}
	}
}