using System.Linq;
using Rotation.StandardBoard;

namespace Rotation.GameObjects.sTests.TestClasses
{
	public class NumericalBoardFiller : IBoardFiller
	{
		public void Fill(IBoard board)
		{

		    var currentColour = 1;
			

			foreach (var square in board.AllSquares().Where(sq => sq.IsSelectable && !sq.HasTile))
			{				
				square.Tile = new TestTile(currentColour);

			    currentColour++;
			}
		}
	}
}