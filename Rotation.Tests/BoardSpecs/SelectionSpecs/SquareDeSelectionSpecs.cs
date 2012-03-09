using Rotation.GameObjects.Board;
using Rotation.GameObjects.Board.Selection;
using SubSpec;
using System.Linq;

namespace Xunit.BoardSpecs.SelectionSpecs
{
	public class SquareDeSelectionSpecs
	{

		private BoardFactory _boardFactory;
		private Board _board;
		private BoardSquareSelector _boardSquareSelector;

		[Specification]
		public void CanDeselectAllSquares()
		{
			"Given that I have a board with 5 squares selected".Context(() =>
			                                                            	{
																				_boardFactory = new BoardFactory();
			                                                            		_board = _boardFactory.Create();
			                                                            		
			                                                            		_board.Columns[1].Squares[0].IsSelected = true;
																				_board.Columns[3].Squares[0].IsSelected = true;
																				_board.Columns[5].Squares[0].IsSelected = true;
																				_board.Rows[4].Squares[0].IsSelected = true;
																				_board.Rows[8].Squares[0].IsSelected = true;


																				_boardSquareSelector = new BoardSquareSelector();

			                                                            	});

			"When I DeSelect all squares".Do(() => _boardSquareSelector.DeSelectAll(_board));

			"Then no squares should be selected".Observation(() => _board.AllSquares().Count(s => s.IsSelected).ShouldEqual(0));
		}
	}
}