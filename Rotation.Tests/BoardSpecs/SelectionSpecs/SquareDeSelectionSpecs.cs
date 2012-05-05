using Rotation.GameObjects.Board;
using SubSpec;
using Rotation.GameObjects.Board.Selection;
using System.Linq;

namespace Rotation.Tests.BoardSpecs.SelectionSpecs
{
	public class SquareDeSelectionSpecs
	{
		[Specification]
		public void CanDeSelectAllSquares()
		{
			IBoard board = null;

			"Given that I have a standard board with some squares selected"
				.Context(() => { board = new BoardFactory().Create();
				               	board[2, 2].IsSelected = true;
				               	board[2, 3].IsSelected = true;
				               	board[4, 5].IsSelected = true;
				               	board[2, 3].IsMainSelection = true;
				});

			"When I call DeSelect all".Do(() => board.DeselectAll());

			"Then no squares should be selected".Observation(() => board.AllSquares().Count(sq => sq.IsSelected).ShouldEqual(0));

			"Then no square should be the main selection".Observation(
				() => board.AllSquares().Count(sq => sq.IsMainSelection).ShouldEqual(0));
		}
	}
}