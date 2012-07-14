using Rotation.GameObjects.StandardBoard;
using Rotation.Tests.Common;
using SubSpec;
using System.Linq;

namespace Rotation.GameObjects.sTests.BoardSpecs
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
				() => board.Rows[0].Count(sq => sq.IsSelectable).ShouldEqual(1));

			"Then the square at index 4 on row 0 should be selectable".Observation(
				() => board.Rows[0][4].IsSelectable.ShouldBeTrue());

			"Then row 1 should have 3 selectable squares".Observation(
				() => board.Rows[1].Count(sq => sq.IsSelectable).ShouldEqual(3));

			"Then the square at index 3 on row 1 should be selectable".Observation(
				() => board.Rows[1][3].IsSelectable.ShouldBeTrue());

			"Then the square at index 4 on row 1 should be selectable".Observation(
				() => board.Rows[1][3].IsSelectable.ShouldBeTrue());

			"Then the square at index 5 on row 1 should be selectable".Observation(
				() => board.Rows[1][3].IsSelectable.ShouldBeTrue());

			"Then row 2 should have 5 selectable squares".Observation(
				() => board.Rows[2].Count(sq => sq.IsSelectable).ShouldEqual(5));

			"Then the square at index 2 on row 2 should be selectable".Observation(
				() => board.Rows[2][2].IsSelectable.ShouldBeTrue());

			"Then the square at index 3 on row 2 should be selectable".Observation(
				() => board.Rows[2][3].IsSelectable.ShouldBeTrue());

			"Then the square at index 4 on row 1 should be selectable".Observation(
				() => board.Rows[2][4].IsSelectable.ShouldBeTrue());

			"Then the square at index 5 on row 2 should be selectable".Observation(
				() => board.Rows[2][5].IsSelectable.ShouldBeTrue());

			"Then the square at index 6 on row 1 should be selectable".Observation(
				() => board.Rows[2][6].IsSelectable.ShouldBeTrue());

			"Then row 3 should have 7 selectable squares".Observation(
				() => board.Rows[3].Count(sq => sq.IsSelectable).ShouldEqual(7));

			"Then the square at index 1 on row 3 should be selectable".Observation(
				() => board.Rows[3][1].IsSelectable.ShouldBeTrue());

			"Then the square at index 2 on row 3 should be selectable".Observation(
				() => board.Rows[3][2].IsSelectable.ShouldBeTrue());

			"Then the square at index 3 on row 3 should be selectable".Observation(
				() => board.Rows[3][3].IsSelectable.ShouldBeTrue());

			"Then the square at index 4 on row 3 should be selectable".Observation(
				() => board.Rows[3][4].IsSelectable.ShouldBeTrue());

			"Then the square at index 5 on row 3 should be selectable".Observation(
				() => board.Rows[3][5].IsSelectable.ShouldBeTrue());

			"Then the square at index 6 on row 3 should be selectable".Observation(
				() => board.Rows[3][6].IsSelectable.ShouldBeTrue());

			"Then the square at index 7 on row 3 should be selectable".Observation(
				() => board.Rows[3][7].IsSelectable.ShouldBeTrue());

			"Then row 4 should have 9 selectable squares".Observation(
				() => board.Rows[4].Count(sq => sq.IsSelectable).ShouldEqual(9));

			"Then the square at index 0 on row 4 should be selectable".Observation(
				() => board.Rows[4][0].IsSelectable.ShouldBeTrue());

			"Then the square at index 1 on row 4 should be selectable".Observation(
				() => board.Rows[4][1].IsSelectable.ShouldBeTrue());

			"Then the square at index 2 on row 4 should be selectable".Observation(
				() => board.Rows[4][4].IsSelectable.ShouldBeTrue());

			"Then the square at index 3 on row 4 should be selectable".Observation(
				() => board.Rows[4][3].IsSelectable.ShouldBeTrue());

			"Then the square at index 4 on row 4 should be selectable".Observation(
				() => board.Rows[4][4].IsSelectable.ShouldBeTrue());

			"Then the square at index 5 on row 4 should be selectable".Observation(
				() => board.Rows[4][5].IsSelectable.ShouldBeTrue());

			"Then the square at index 6 on row 4 should be selectable".Observation(
				() => board.Rows[4][6].IsSelectable.ShouldBeTrue());

			"Then the square at index 7 on row 4 should be selectable".Observation(
				() => board.Rows[4][7].IsSelectable.ShouldBeTrue());

			"Then the square at index 8 on row 4 should be selectable".Observation(
				() => board.Rows[4][8].IsSelectable.ShouldBeTrue());

			"Then row 5 should have 7 selectable squares".Observation(
				() => board.Rows[5].Count(sq => sq.IsSelectable).ShouldEqual(7));

			"Then the square at index 1 on row 5 should be selectable".Observation(
				() => board.Rows[5][1].IsSelectable.ShouldBeTrue());

			"Then the square at index 2 on row 5 should be selectable".Observation(
				() => board.Rows[5][2].IsSelectable.ShouldBeTrue());

			"Then the square at index 3 on row 5 should be selectable".Observation(
				() => board.Rows[5][3].IsSelectable.ShouldBeTrue());

			"Then the square at index 4 on row 5 should be selectable".Observation(
				() => board.Rows[5][4].IsSelectable.ShouldBeTrue());

			"Then the square at index 5 on row 5 should be selectable".Observation(
				() => board.Rows[5][5].IsSelectable.ShouldBeTrue());

			"Then the square at index 6 on row 5 should be selectable".Observation(
				() => board.Rows[5][6].IsSelectable.ShouldBeTrue());

			"Then the square at index 7 on row 5 should be selectable".Observation(
				() => board.Rows[5][7].IsSelectable.ShouldBeTrue());

			"Then row 6 should have 5 selectable squares".Observation(
				() => board.Rows[6].Count(sq => sq.IsSelectable).ShouldEqual(5));

			"Then the square at index 2 on row 6 should be selectable".Observation(
				() => board.Rows[6][2].IsSelectable.ShouldBeTrue());

			"Then the square at index 3 on row 6 should be selectable".Observation(
				() => board.Rows[6][3].IsSelectable.ShouldBeTrue());

			"Then the square at index 4 on row 6 should be selectable".Observation(
				() => board.Rows[6][4].IsSelectable.ShouldBeTrue());

			"Then the square at index 5 on row 6 should be selectable".Observation(
				() => board.Rows[6][5].IsSelectable.ShouldBeTrue());

			"Then the square at index 6 on row 6 should be selectable".Observation(
				() => board.Rows[6][6].IsSelectable.ShouldBeTrue());

			"Then row 7 should have 3 selectable squares".Observation(
				() => board.Rows[7].Count(sq => sq.IsSelectable).ShouldEqual(3));

			"Then the square at index 7 on row 1 should be selectable".Observation(
				() => board.Rows[7][3].IsSelectable.ShouldBeTrue());

			"Then the square at index 7 on row 1 should be selectable".Observation(
				() => board.Rows[7][3].IsSelectable.ShouldBeTrue());

			"Then the square at index 7 on row 1 should be selectable".Observation(
				() => board.Rows[7][3].IsSelectable.ShouldBeTrue());

			"Then row 8 should have one selectable square".Observation(
				() => board.Rows[8].Count(sq => sq.IsSelectable).ShouldEqual(1));

			"Then the square at index 4 on row 8 should be selectable".Observation(
				() => board.Rows[8][4].IsSelectable.ShouldBeTrue());
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
										board.Columns[i][j].ShouldBeTheSameAs(board.Rows[j][i]);
									}

			                    }
			                });
		}

        [Specification]
        public void BoardFactoryShouldHaveSquaresThatCanBeUsedInWordsInTheCorrectPositions()
        {
            Board board = null;
            BoardFactory boardFactory = null;

            "Given that I have a standard board factory".Context(() => boardFactory = new BoardFactory());

            "When I create a board".Do(() => board = boardFactory.Create());

            "Then row 0 should have one square that can be used in a word".Observation(
                () => board.Rows[0].Count(sq => sq.CanUseInWord).ShouldEqual(1));

            "Then the square at index 4 on row 0 should be able to be used in a word".Observation(
                () => board.Rows[0][4].CanUseInWord.ShouldBeTrue());

            "Then row 1 should have 3 square that can be used in a words".Observation(
                () => board.Rows[1].Count(sq => sq.CanUseInWord).ShouldEqual(3));

            "Then the square at index 3 on row 1 should be able to be used in a word".Observation(
                () => board.Rows[1][3].CanUseInWord.ShouldBeTrue());

            "Then the square at index 4 on row 1 should be able to be used in a word".Observation(
                () => board.Rows[1][3].CanUseInWord.ShouldBeTrue());

            "Then the square at index 5 on row 1 should be able to be used in a word".Observation(
                () => board.Rows[1][3].CanUseInWord.ShouldBeTrue());

            "Then row 2 should have 5 square that can be used in a words".Observation(
                () => board.Rows[2].Count(sq => sq.CanUseInWord).ShouldEqual(5));

            "Then the square at index 2 on row 2 should be able to be used in a word".Observation(
                () => board.Rows[2][2].CanUseInWord.ShouldBeTrue());

            "Then the square at index 3 on row 2 should be able to be used in a word".Observation(
                () => board.Rows[2][3].CanUseInWord.ShouldBeTrue());

            "Then the square at index 4 on row 1 should be able to be used in a word".Observation(
                () => board.Rows[2][4].CanUseInWord.ShouldBeTrue());

            "Then the square at index 5 on row 2 should be able to be used in a word".Observation(
                () => board.Rows[2][5].CanUseInWord.ShouldBeTrue());

            "Then the square at index 6 on row 1 should be able to be used in a word".Observation(
                () => board.Rows[2][6].CanUseInWord.ShouldBeTrue());

            "Then row 3 should have 7 square that can be used in a words".Observation(
                () => board.Rows[3].Count(sq => sq.CanUseInWord).ShouldEqual(7));

            "Then the square at index 1 on row 3 should be able to be used in a word".Observation(
                () => board.Rows[3][1].CanUseInWord.ShouldBeTrue());

            "Then the square at index 2 on row 3 should be able to be used in a word".Observation(
                () => board.Rows[3][2].CanUseInWord.ShouldBeTrue());

            "Then the square at index 3 on row 3 should be able to be used in a word".Observation(
                () => board.Rows[3][3].CanUseInWord.ShouldBeTrue());

            "Then the square at index 4 on row 3 should be able to be used in a word".Observation(
                () => board.Rows[3][4].CanUseInWord.ShouldBeTrue());

            "Then the square at index 5 on row 3 should be able to be used in a word".Observation(
                () => board.Rows[3][5].CanUseInWord.ShouldBeTrue());

            "Then the square at index 6 on row 3 should be able to be used in a word".Observation(
                () => board.Rows[3][6].CanUseInWord.ShouldBeTrue());

            "Then the square at index 7 on row 3 should be able to be used in a word".Observation(
                () => board.Rows[3][7].CanUseInWord.ShouldBeTrue());

            "Then row 4 should have 9 square that can be used in a words".Observation(
                () => board.Rows[4].Count(sq => sq.CanUseInWord).ShouldEqual(9));

            "Then the square at index 0 on row 4 should be able to be used in a word".Observation(
                () => board.Rows[4][0].CanUseInWord.ShouldBeTrue());

            "Then the square at index 1 on row 4 should be able to be used in a word".Observation(
                () => board.Rows[4][1].CanUseInWord.ShouldBeTrue());

            "Then the square at index 2 on row 4 should be able to be used in a word".Observation(
                () => board.Rows[4][4].CanUseInWord.ShouldBeTrue());

            "Then the square at index 3 on row 4 should be able to be used in a word".Observation(
                () => board.Rows[4][3].CanUseInWord.ShouldBeTrue());

            "Then the square at index 4 on row 4 should be able to be used in a word".Observation(
                () => board.Rows[4][4].CanUseInWord.ShouldBeTrue());

            "Then the square at index 5 on row 4 should be able to be used in a word".Observation(
                () => board.Rows[4][5].CanUseInWord.ShouldBeTrue());

            "Then the square at index 6 on row 4 should be able to be used in a word".Observation(
                () => board.Rows[4][6].CanUseInWord.ShouldBeTrue());

            "Then the square at index 7 on row 4 should be able to be used in a word".Observation(
                () => board.Rows[4][7].CanUseInWord.ShouldBeTrue());

            "Then the square at index 8 on row 4 should be able to be used in a word".Observation(
                () => board.Rows[4][8].CanUseInWord.ShouldBeTrue());

            "Then row 5 should have 7 square that can be used in a words".Observation(
                () => board.Rows[5].Count(sq => sq.CanUseInWord).ShouldEqual(7));

            "Then the square at index 1 on row 5 should be able to be used in a word".Observation(
                () => board.Rows[5][1].CanUseInWord.ShouldBeTrue());

            "Then the square at index 2 on row 5 should be able to be used in a word".Observation(
                () => board.Rows[5][2].CanUseInWord.ShouldBeTrue());

            "Then the square at index 3 on row 5 should be able to be used in a word".Observation(
                () => board.Rows[5][3].CanUseInWord.ShouldBeTrue());

            "Then the square at index 4 on row 5 should be able to be used in a word".Observation(
                () => board.Rows[5][4].CanUseInWord.ShouldBeTrue());

            "Then the square at index 5 on row 5 should be able to be used in a word".Observation(
                () => board.Rows[5][5].CanUseInWord.ShouldBeTrue());

            "Then the square at index 6 on row 5 should be able to be used in a word".Observation(
                () => board.Rows[5][6].CanUseInWord.ShouldBeTrue());

            "Then the square at index 7 on row 5 should be able to be used in a word".Observation(
                () => board.Rows[5][7].CanUseInWord.ShouldBeTrue());

            "Then row 6 should have 5 square that can be used in a words".Observation(
                () => board.Rows[6].Count(sq => sq.CanUseInWord).ShouldEqual(5));

            "Then the square at index 2 on row 6 should be able to be used in a word".Observation(
                () => board.Rows[6][2].CanUseInWord.ShouldBeTrue());

            "Then the square at index 3 on row 6 should be able to be used in a word".Observation(
                () => board.Rows[6][3].CanUseInWord.ShouldBeTrue());

            "Then the square at index 4 on row 6 should be able to be used in a word".Observation(
                () => board.Rows[6][4].CanUseInWord.ShouldBeTrue());

            "Then the square at index 5 on row 6 should be able to be used in a word".Observation(
                () => board.Rows[6][5].CanUseInWord.ShouldBeTrue());

            "Then the square at index 6 on row 6 should be able to be used in a word".Observation(
                () => board.Rows[6][6].CanUseInWord.ShouldBeTrue());

            "Then row 7 should have 3 square that can be used in a words".Observation(
                () => board.Rows[7].Count(sq => sq.CanUseInWord).ShouldEqual(3));

            "Then the square at index 7 on row 1 should be able to be used in a word".Observation(
                () => board.Rows[7][3].CanUseInWord.ShouldBeTrue());

            "Then the square at index 7 on row 1 should be able to be used in a word".Observation(
                () => board.Rows[7][3].CanUseInWord.ShouldBeTrue());

            "Then the square at index 7 on row 1 should be able to be used in a word".Observation(
                () => board.Rows[7][3].CanUseInWord.ShouldBeTrue());

            "Then row 8 should have one square that can be used in a word".Observation(
                () => board.Rows[8].Count(sq => sq.CanUseInWord).ShouldEqual(1));

            "Then the square at index 4 on row 8 should be able to be used in a word".Observation(
                () => board.Rows[8][4].CanUseInWord.ShouldBeTrue());
        }
	}
}