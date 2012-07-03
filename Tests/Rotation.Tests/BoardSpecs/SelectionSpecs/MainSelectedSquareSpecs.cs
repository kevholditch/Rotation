using Rotation.GameObjects.StandardBoard;
using Rotation.GameObjects.StandardBoard.Selection;
using Rotation.Tests.Common;
using SubSpec;

namespace Rotation.GameObjects.sTests.BoardSpecs.SelectionSpecs
{
	public class MainSelectedSquareSpecs
	{
		[Specification]
		public void CanFindTheMainSelectedSquare()
		{
			SquareSelector squareSelector = default(SquareSelector);
			Board board = null;
			var boardCoordinate = default(BoardCoordinate); 

			"Given I have selected the centre square on a normal board".Context(() =>
			{
				board = new BoardFactory().Create();
				squareSelector = new SquareSelector();
				squareSelector.Select(board, 4, 4);
			});

			"When I get the selected square".Do(() => boardCoordinate = board.GetMainSelectedSquare());

			"Then the x value of the coordindate should be 4".Observation(() => boardCoordinate.X.ShouldEqual(4));

			"Then the y value of the coordinate should be 4".Observation(() => boardCoordinate.Y.ShouldEqual(4));

		}
	}
}