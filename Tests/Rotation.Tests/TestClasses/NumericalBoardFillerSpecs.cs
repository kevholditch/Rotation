using System.Linq;
using Rotation.StandardBoard;
using SubSpec;

namespace Rotation.GameObjects.sTests.TestClasses
{
	public class NumericalBoardFillerSpecs
	{
		[Specification]
		public void CanFillAnEmptyBoard()
		{
			var numericalBoardFiller = default(NumericalBoardFiller);
			var board = default(Board);

			"Given that I have a board with with 41 selectable squares".Context(() =>
			{				
				numericalBoardFiller = new NumericalBoardFiller();
				board = new BoardFactory().Create();
			});

			"When I fill the board".Do(() => numericalBoardFiller.Fill(board));

			"Then every square that is not selectable should not contain a tile".Observation(
				() => board.AllSquares().Where(sq => !sq.IsSelectable && sq.HasTile).Count().ShouldEqual(0));

			"Then every square that is selectable should contain a tile".Observation(
				() => board.AllSquares().Where(sq => sq.IsSelectable && sq.HasTile).Count().ShouldEqual(41));

		}

		[Specification]
		public void SquaresShouldContainNumbersInOrder()
		{
			var numericalBoardFiller = default(NumericalBoardFiller);
			var board = default(Board);

			"Given that I have a board with with 41 selectable squares".Context(() =>
			{
				numericalBoardFiller = new NumericalBoardFiller();
				board = new BoardFactory().Create();
			});

			"When I fill the board".Do(() => numericalBoardFiller.Fill(board));

			"Then the 1st selectable square should contain the colour 1".Observation(
				() => board.AllSelectableSquaresWithTiles()[0].Colour.ShouldEqual(1));

			"Then the 2nd selectable square should contain the colour 2".Observation(
				() => board.AllSelectableSquaresWithTiles()[1].Colour.ShouldEqual(2));

			"Then the 3rd selectable square should contain the colour 3".Observation(
				() => board.AllSelectableSquaresWithTiles()[2].Colour.ShouldEqual(3));

			"Then the 4th selectable square should contain the colour 4".Observation(
				() => board.AllSelectableSquaresWithTiles()[3].Colour.ShouldEqual(4));

			"Then the 5th selectable square should contain the colour 5".Observation(
				() => board.AllSelectableSquaresWithTiles()[4].Colour.ShouldEqual(5));

			"Then the 6th selectable square should contain the colour 6".Observation(
				() => board.AllSelectableSquaresWithTiles()[5].Colour.ShouldEqual(6));

			"Then the 7tn selectable square should contain the colour 7".Observation(
				() => board.AllSelectableSquaresWithTiles()[6].Colour.ShouldEqual(7));

			"Then the 8th selectable square should contain the colour 8".Observation(
				() => board.AllSelectableSquaresWithTiles()[7].Colour.ShouldEqual(8));

			"Then the 9th selectable square should contain the colour 9".Observation(
				() => board.AllSelectableSquaresWithTiles()[8].Colour.ShouldEqual(9));

			"Then the 10th selectable square should contain the colour 10".Observation(
				() => board.AllSelectableSquaresWithTiles()[9].Colour.ShouldEqual(10));

			"Then the 11th selectable square should contain the colour 11".Observation(
				() => board.AllSelectableSquaresWithTiles()[10].Colour.ShouldEqual(11));

			"Then the 12th selectable square should contain the colour 12".Observation(
				() => board.AllSelectableSquaresWithTiles()[11].Colour.ShouldEqual(12));

			"Then the 13th selectable square should contain the colour 13".Observation(
				() => board.AllSelectableSquaresWithTiles()[12].Colour.ShouldEqual(13));

			"Then the 14th selectable square should contain the colour 14".Observation(
				() => board.AllSelectableSquaresWithTiles()[13].Colour.ShouldEqual(14));

			"Then the 15th selectable square should contain the colour 15".Observation(
				() => board.AllSelectableSquaresWithTiles()[14].Colour.ShouldEqual(15));

			"Then the 16th selectable square should contain the colour 16".Observation(
				() => board.AllSelectableSquaresWithTiles()[15].Colour.ShouldEqual(16));

			"Then the 17th selectable square should contain the colour 17".Observation(
				() => board.AllSelectableSquaresWithTiles()[16].Colour.ShouldEqual(17));

			"Then the 18th selectable square should contain the colour 18".Observation(
				() => board.AllSelectableSquaresWithTiles()[17].Colour.ShouldEqual(18));

			"Then the 19th selectable square should contain the colour 19".Observation(
				() => board.AllSelectableSquaresWithTiles()[18].Colour.ShouldEqual(19));

			"Then the 20th selectable square should contain the colour 20".Observation(
				() => board.AllSelectableSquaresWithTiles()[19].Colour.ShouldEqual(20));

			"Then the 21st selectable square should contain the colour 21".Observation(
				() => board.AllSelectableSquaresWithTiles()[20].Colour.ShouldEqual(21));

			"Then the 22nd selectable square should contain the colour 22".Observation(
				() => board.AllSelectableSquaresWithTiles()[21].Colour.ShouldEqual(22));

			"Then the 23rd selectable square should contain the colour 23".Observation(
				() => board.AllSelectableSquaresWithTiles()[22].Colour.ShouldEqual(23));

			"Then the 24th selectable square should contain the colour 24".Observation(
				() => board.AllSelectableSquaresWithTiles()[23].Colour.ShouldEqual(24));

			"Then the 25th selectable square should contain the colour 25".Observation(
				() => board.AllSelectableSquaresWithTiles()[24].Colour.ShouldEqual(25));

			"Then the 26th selectable square should contain the colour 26".Observation(
				() => board.AllSelectableSquaresWithTiles()[25].Colour.ShouldEqual(26));		

			"Then the 27th selectable square should contain the colour 27".Observation(
				() => board.AllSelectableSquaresWithTiles()[26].Colour.ShouldEqual(27));

			"Then the 28th selectable square should contain the colour 28".Observation(
				() => board.AllSelectableSquaresWithTiles()[27].Colour.ShouldEqual(28));

			"Then the 29th selectable square should contain the colour 29".Observation(
				() => board.AllSelectableSquaresWithTiles()[28].Colour.ShouldEqual(29));

			"Then the 30th selectable square should contain the colour 30".Observation(
				() => board.AllSelectableSquaresWithTiles()[29].Colour.ShouldEqual(30));

			"Then the 31st selectable square should contain the colour 31".Observation(
				() => board.AllSelectableSquaresWithTiles()[30].Colour.ShouldEqual(31));

			"Then the 32nd selectable square should contain the colour 32".Observation(
				() => board.AllSelectableSquaresWithTiles()[31].Colour.ShouldEqual(32));

			"Then the 33rd selectable square should contain the colour 33".Observation(
				() => board.AllSelectableSquaresWithTiles()[32].Colour.ShouldEqual(33));

			"Then the 34th selectable square should contain the colour 34".Observation(
				() => board.AllSelectableSquaresWithTiles()[33].Colour.ShouldEqual(34));

			"Then the 35th selectable square should contain the colour 35".Observation(
				() => board.AllSelectableSquaresWithTiles()[34].Colour.ShouldEqual(35));

			"Then the 36th selectable square should contain the colour 36".Observation(
				() => board.AllSelectableSquaresWithTiles()[35].Colour.ShouldEqual(36));

			"Then the 37th selectable square should contain the colour 37".Observation(
				() => board.AllSelectableSquaresWithTiles()[36].Colour.ShouldEqual(37));

			"Then the 38th selectable square should contain the colour 38".Observation(
				() => board.AllSelectableSquaresWithTiles()[37].Colour.ShouldEqual(38));

			"Then the 39th selectable square should contain the colour 39".Observation(
				() => board.AllSelectableSquaresWithTiles()[38].Colour.ShouldEqual(39));

			"Then the 40th selectable square should contain the colour 40".Observation(
				() => board.AllSelectableSquaresWithTiles()[39].Colour.ShouldEqual(40));

			"Then the 41st selectable square should contain the colour 41".Observation(
				() => board.AllSelectableSquaresWithTiles()[40].Colour.ShouldEqual(41));
		}

	}
}