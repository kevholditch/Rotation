using Rotation.StandardBoard;
using Rotation.StandardBoard.Selection;
using SubSpec;
using System.Linq;

namespace Rotation.GameObjects.sTests.BoardSpecs.SelectionSpecs
{
	public class SquareDeSelectionSpecs
	{
		[Specification]
		public void CanDeSelectAllSquares()
		{
		    var board = default(Board);
		    var squareSelector = default(SquareSelector);

			"Given that I have a standard board with some squares selected"
				.Context(() => {
                    
                        squareSelector = new SquareSelector();
                        board = new BoardFactory().Create();
				        board[2, 2].IsSelected = true;
				        board[2, 3].IsSelected = true;
				        board[4, 5].IsSelected = true;
				        board[2, 3].IsMainSelection = true;
				});

			"When I call DeSelect all".Do(() => squareSelector.DeSelect(board));

			"Then no squares should be selected".Observation(() => board.AllSquares().Count(sq => sq.IsSelected).ShouldEqual(0));

			"Then no square should be the main selection".Observation(
				() => board.AllSquares().Count(sq => sq.IsMainSelection).ShouldEqual(0));
		}
	}
}