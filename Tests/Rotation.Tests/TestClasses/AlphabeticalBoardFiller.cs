using System.Linq;
using Rotation.Letters;
using Rotation.StandardBoard;

namespace Rotation.GameObjects.sTests.TestClasses
{
	public class AlphabeticalBoardFiller : IBoardFiller
	{
		public void Fill(IBoard board)
		{

			var currentLetter = 'A';
			var lookup = new LetterLookup();
			

			foreach (var square in board.AllSquares().Where(sq => sq.IsSelectable && !sq.HasTile))
			{				
				square.Tile = new TestTile(lookup.Letters.First(l => l.Value == currentLetter));

				if (currentLetter == 'Z')
				{
					currentLetter = 'A';
				}else
				{
					currentLetter++;
				}
			}
		}
	}
}