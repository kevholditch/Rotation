using System.Linq;
using FakeItEasy;
using Rotation.GameObjects.Board;
using Rotation.GameObjects.Letters;
using Rotation.GameObjects.Tiles;
using SubSpec;

namespace Rotation.Tests.TestClasses
{
	public class AlphabeticalBoardFillerSpecs
	{
		[Specification]
		public void CanFillAnEmptyBoard()
		{
			var alphabeticalBoardFiller = default(AlphabeticalBoardFiller);
			var board = default(Board);

			"Given that I have a board with with 41 selectable squares".Context(() =>
			{				
				alphabeticalBoardFiller = new AlphabeticalBoardFiller();
				board = new BoardFactory().Create();
			});

			"When I fill the board".Do(() => alphabeticalBoardFiller.Fill(board));

			"Then every square that is not selectable should not contain a tile".Observation(
				() => board.AllSquares().Where(sq => !sq.IsSelectable && sq.HasTile).Count().ShouldEqual(0));

			"Then every square that is selectable should contain a tile".Observation(
				() => board.AllSquares().Where(sq => sq.IsSelectable && sq.HasTile).Count().ShouldEqual(41));

		}

		[Specification]
		public void SquaresShouldContainLettersInAlphabeticalOrder()
		{
			var alphabeticalBoardFiller = default(AlphabeticalBoardFiller);
			var board = default(Board);

			"Given that I have a board with with 41 selectable squares".Context(() =>
			{
				alphabeticalBoardFiller = new AlphabeticalBoardFiller();
				board = new BoardFactory().Create();
			});

			"When I fill the board".Do(() => alphabeticalBoardFiller.Fill(board));

			"Then the 1st selectable square should contain the letter A".Observation(
				() => board.AllSelectableSquaresWithTiles()[0].Letter.Value.ShouldEqual('A'));

			"Then the 2nd selectable square should contain the letter B".Observation(
				() => board.AllSelectableSquaresWithTiles()[1].Letter.Value.ShouldEqual('B'));

			"Then the 3rd selectable square should contain the letter C".Observation(
				() => board.AllSelectableSquaresWithTiles()[2].Letter.Value.ShouldEqual('C'));

			"Then the 4th selectable square should contain the letter D".Observation(
				() => board.AllSelectableSquaresWithTiles()[3].Letter.Value.ShouldEqual('D'));

			"Then the 5th selectable square should contain the letter E".Observation(
				() => board.AllSelectableSquaresWithTiles()[4].Letter.Value.ShouldEqual('E'));

			"Then the 6th selectable square should contain the letter F".Observation(
				() => board.AllSelectableSquaresWithTiles()[5].Letter.Value.ShouldEqual('F'));

			"Then the 7tn selectable square should contain the letter G".Observation(
				() => board.AllSelectableSquaresWithTiles()[6].Letter.Value.ShouldEqual('G'));

			"Then the 8th selectable square should contain the letter H".Observation(
				() => board.AllSelectableSquaresWithTiles()[7].Letter.Value.ShouldEqual('H'));

			"Then the 9th selectable square should contain the letter I".Observation(
				() => board.AllSelectableSquaresWithTiles()[8].Letter.Value.ShouldEqual('I'));

			"Then the 10th selectable square should contain the letter J".Observation(
				() => board.AllSelectableSquaresWithTiles()[9].Letter.Value.ShouldEqual('J'));

			"Then the 11th selectable square should contain the letter K".Observation(
				() => board.AllSelectableSquaresWithTiles()[10].Letter.Value.ShouldEqual('K'));

			"Then the 12th selectable square should contain the letter L".Observation(
				() => board.AllSelectableSquaresWithTiles()[11].Letter.Value.ShouldEqual('L'));

			"Then the 13th selectable square should contain the letter M".Observation(
				() => board.AllSelectableSquaresWithTiles()[12].Letter.Value.ShouldEqual('M'));

			"Then the 14th selectable square should contain the letter N".Observation(
				() => board.AllSelectableSquaresWithTiles()[13].Letter.Value.ShouldEqual('N'));

			"Then the 15th selectable square should contain the letter O".Observation(
				() => board.AllSelectableSquaresWithTiles()[14].Letter.Value.ShouldEqual('O'));

			"Then the 16th selectable square should contain the letter P".Observation(
				() => board.AllSelectableSquaresWithTiles()[15].Letter.Value.ShouldEqual('P'));

			"Then the 17th selectable square should contain the letter Q".Observation(
				() => board.AllSelectableSquaresWithTiles()[16].Letter.Value.ShouldEqual('Q'));

			"Then the 18th selectable square should contain the letter R".Observation(
				() => board.AllSelectableSquaresWithTiles()[17].Letter.Value.ShouldEqual('R'));

			"Then the 19th selectable square should contain the letter S".Observation(
				() => board.AllSelectableSquaresWithTiles()[18].Letter.Value.ShouldEqual('S'));

			"Then the 20th selectable square should contain the letter T".Observation(
				() => board.AllSelectableSquaresWithTiles()[19].Letter.Value.ShouldEqual('T'));

			"Then the 21st selectable square should contain the letter U".Observation(
				() => board.AllSelectableSquaresWithTiles()[20].Letter.Value.ShouldEqual('U'));

			"Then the 22nd selectable square should contain the letter V".Observation(
				() => board.AllSelectableSquaresWithTiles()[21].Letter.Value.ShouldEqual('V'));

			"Then the 23rd selectable square should contain the letter W".Observation(
				() => board.AllSelectableSquaresWithTiles()[22].Letter.Value.ShouldEqual('W'));

			"Then the 24th selectable square should contain the letter X".Observation(
				() => board.AllSelectableSquaresWithTiles()[23].Letter.Value.ShouldEqual('X'));

			"Then the 25th selectable square should contain the letter Y".Observation(
				() => board.AllSelectableSquaresWithTiles()[24].Letter.Value.ShouldEqual('Y'));

			"Then the 26th selectable square should contain the letter Z".Observation(
				() => board.AllSelectableSquaresWithTiles()[25].Letter.Value.ShouldEqual('Z'));		

			"Then the 27th selectable square should contain the letter A".Observation(
				() => board.AllSelectableSquaresWithTiles()[26].Letter.Value.ShouldEqual('A'));

			"Then the 28th selectable square should contain the letter B".Observation(
				() => board.AllSelectableSquaresWithTiles()[27].Letter.Value.ShouldEqual('B'));

			"Then the 29th selectable square should contain the letter C".Observation(
				() => board.AllSelectableSquaresWithTiles()[28].Letter.Value.ShouldEqual('C'));

			"Then the 30th selectable square should contain the letter D".Observation(
				() => board.AllSelectableSquaresWithTiles()[29].Letter.Value.ShouldEqual('D'));

			"Then the 31st selectable square should contain the letter E".Observation(
				() => board.AllSelectableSquaresWithTiles()[30].Letter.Value.ShouldEqual('E'));

			"Then the 32nd selectable square should contain the letter F".Observation(
				() => board.AllSelectableSquaresWithTiles()[31].Letter.Value.ShouldEqual('F'));

			"Then the 33rd selectable square should contain the letter G".Observation(
				() => board.AllSelectableSquaresWithTiles()[32].Letter.Value.ShouldEqual('G'));

			"Then the 34th selectable square should contain the letter H".Observation(
				() => board.AllSelectableSquaresWithTiles()[33].Letter.Value.ShouldEqual('H'));

			"Then the 35th selectable square should contain the letter I".Observation(
				() => board.AllSelectableSquaresWithTiles()[34].Letter.Value.ShouldEqual('I'));

			"Then the 36th selectable square should contain the letter J".Observation(
				() => board.AllSelectableSquaresWithTiles()[35].Letter.Value.ShouldEqual('J'));

			"Then the 37th selectable square should contain the letter K".Observation(
				() => board.AllSelectableSquaresWithTiles()[36].Letter.Value.ShouldEqual('K'));

			"Then the 38th selectable square should contain the letter L".Observation(
				() => board.AllSelectableSquaresWithTiles()[37].Letter.Value.ShouldEqual('L'));

			"Then the 39th selectable square should contain the letter M".Observation(
				() => board.AllSelectableSquaresWithTiles()[38].Letter.Value.ShouldEqual('M'));

			"Then the 40th selectable square should contain the letter N".Observation(
				() => board.AllSelectableSquaresWithTiles()[39].Letter.Value.ShouldEqual('N'));

			"Then the 41st selectable square should contain the letter O".Observation(
				() => board.AllSelectableSquaresWithTiles()[40].Letter.Value.ShouldEqual('O'));
		}

	}
}