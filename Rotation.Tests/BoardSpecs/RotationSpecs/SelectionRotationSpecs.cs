using Rotation.GameObjects.Board;
using Rotation.GameObjects.Board.Rotation;
using Rotation.GameObjects.Board.Selection;
using Rotation.GameObjects.Tiles;
using Rotation.Tests.TestClasses;
using SubSpec;

namespace Rotation.Tests.BoardSpecs.RotationSpecs
{
	public class SelectionRotationSpecs
	{
		[Specification]
		public void CanRotateASelectionRight()
		{
			var selectionRotator = new SelectionRotatator();
			var board = default(IBoard);
			var squareSelector = new SquareSelector();

			"Given that I have a board filled alphabetically and I have selected the centre square".Context(() =>
			                                                                                                	{
			                                                                                                		board = new BoardFactory().Create();			                                                                                                		
																													new AlphabeticalBoardFiller().Fill(board);																													
																													squareSelector.Select(board, 4, 4);
			                                                                                                	});
			"When I rotate the board right".Do(() => selectionRotator.Right(board));

			"Then square 4, 0 will contain letter Q".Observation(() => board[4, 0].Letter.Value.ShouldEqual('Q'));

			"Then square 3, 1 will contain letter B".Observation(() => board[3, 1].Letter.Value.ShouldEqual('B'));

			"Then square 4, 1 will contain letter R".Observation(() => board[4, 1].Letter.Value.ShouldEqual('R'));

			"Then square 5, 1 will contain letter D".Observation(() => board[5, 1].Letter.Value.ShouldEqual('D'));

			"Then square 2, 2 will contain letter E".Observation(() => board[2, 2].Letter.Value.ShouldEqual('E'));

			"Then square 3, 2 will contain letter F".Observation(() => board[3, 2].Letter.Value.ShouldEqual('F'));

			"Then square 4, 2 will contain letter S".Observation(() => board[4, 2].Letter.Value.ShouldEqual('S'));

			"Then square 5, 2 will contain letter H".Observation(() => board[5, 2].Letter.Value.ShouldEqual('H'));

			"Then square 6, 2 will contain letter I".Observation(() => board[6, 2].Letter.Value.ShouldEqual('I'));

			"Then square 1, 3 will contain letter J".Observation(() => board[1, 3].Letter.Value.ShouldEqual('J'));

			"Then square 2, 3 will contain letter K".Observation(() => board[2, 3].Letter.Value.ShouldEqual('K'));

			"Then square 3, 3 will contain letter L".Observation(() => board[3, 3].Letter.Value.ShouldEqual('L'));

			"Then square 4, 3 will contain letter T".Observation(() => board[4, 3].Letter.Value.ShouldEqual('T'));

			"Then square 5, 3 will contain letter N".Observation(() => board[5, 3].Letter.Value.ShouldEqual('N'));

			"Then square 6, 3 will contain letter O".Observation(() => board[6, 3].Letter.Value.ShouldEqual('O'));

			"Then square 7, 3 will contain letter P".Observation(() => board[7, 3].Letter.Value.ShouldEqual('P'));

			"Then square 0, 4 will contain letter O".Observation(() => board[0, 4].Letter.Value.ShouldEqual('O'));

			"Then square 1, 4 will contain letter M".Observation(() => board[1, 4].Letter.Value.ShouldEqual('M'));

			"Then square 2, 4 will contain letter I".Observation(() => board[2, 4].Letter.Value.ShouldEqual('I'));

			"Then square 3, 4 will contain letter C".Observation(() => board[3, 4].Letter.Value.ShouldEqual('C'));

			"Then square 4, 4 will contain letter U".Observation(() => board[4, 4].Letter.Value.ShouldEqual('U'));

			"Then square 5, 4 will contain letter M".Observation(() => board[5, 4].Letter.Value.ShouldEqual('M'));

			"Then square 6, 4 will contain letter G".Observation(() => board[6, 4].Letter.Value.ShouldEqual('G'));

			"Then square 7, 4 will contain letter C".Observation(() => board[7, 4].Letter.Value.ShouldEqual('C'));

			"Then square 8, 4 will contain letter A".Observation(() => board[8, 4].Letter.Value.ShouldEqual('A'));

			"Then square 1, 5 will contain letter Z".Observation(() => board[1, 5].Letter.Value.ShouldEqual('Z'));

			"Then square 2, 5 will contain letter A".Observation(() => board[2, 5].Letter.Value.ShouldEqual('A'));

			"Then square 3, 5 will contain letter B".Observation(() => board[3, 5].Letter.Value.ShouldEqual('B'));

			"Then square 4, 5 will contain letter V".Observation(() => board[4, 5].Letter.Value.ShouldEqual('V'));

			"Then square 5, 5 will contain letter D".Observation(() => board[5, 5].Letter.Value.ShouldEqual('D'));

			"Then square 6, 5 will contain letter E".Observation(() => board[6, 5].Letter.Value.ShouldEqual('E'));

			"Then square 7, 5 will contain letter F".Observation(() => board[7, 5].Letter.Value.ShouldEqual('F'));

			"Then square 2, 6 will contain letter G".Observation(() => board[2, 6].Letter.Value.ShouldEqual('G'));

			"Then square 3, 6 will contain letter H".Observation(() => board[3, 6].Letter.Value.ShouldEqual('H'));

			"Then square 4, 6 will contain letter W".Observation(() => board[4, 6].Letter.Value.ShouldEqual('W'));

			"Then square 5, 6 will contain letter J".Observation(() => board[5, 6].Letter.Value.ShouldEqual('J'));

			"Then square 6, 6 will contain letter K".Observation(() => board[6, 6].Letter.Value.ShouldEqual('K'));
			
			"Then square 3, 7 will contain letter L".Observation(() => board[3, 7].Letter.Value.ShouldEqual('L'));

			"Then square 4, 7 will contain letter X".Observation(() => board[4, 7].Letter.Value.ShouldEqual('X'));

			"Then square 5, 7 will contain letter N".Observation(() => board[5, 7].Letter.Value.ShouldEqual('N'));

			"Then square 4, 8 will contain letter Y".Observation(() => board[4, 8].Letter.Value.ShouldEqual('Y'));
		}

		[Specification]
		public void CanRotateASmallSelectionRight()
		{
			var selectionRotator = new SelectionRotatator();
			var board = default(IBoard);
			var squareSelector = new SquareSelector();

			"Given that I have a board filled alphabetically and I have selected the square 5, 2".Context(() =>
			{
				board = new BoardFactory().Create();
				new AlphabeticalBoardFiller().Fill(board);
				squareSelector.Select(board, 5, 2);
			});
			"When I rotate the board right".Do(() => selectionRotator.Right(board));

			"Then square 4, 1 will contain letter C".Observation(() => board[4, 1].Letter.Value.ShouldEqual('C'));

			"Then square 5, 1 will contain letter G".Observation(() => board[5, 1].Letter.Value.ShouldEqual('G'));

			"Then square 4, 2 will contain letter N".Observation(() => board[4, 2].Letter.Value.ShouldEqual('N'));

			"Then square 5, 2 will contain letter H".Observation(() => board[5, 2].Letter.Value.ShouldEqual('H'));

			"Then square 4, 3 will contain letter M".Observation(() => board[4, 3].Letter.Value.ShouldEqual('M'));

			"Then square 5, 3 will contain letter I".Observation(() => board[5, 3].Letter.Value.ShouldEqual('I'));

			"Then square 6, 3 will contain letter O".Observation(() => board[6, 3].Letter.Value.ShouldEqual('O'));

			"Then square 7, 3 will contain letter P".Observation(() => board[7, 3].Letter.Value.ShouldEqual('P'));

		}

		[Specification]
		public void CanRotateASelectionLeft()
		{
			var selectionRotator = new SelectionRotatator();
			var board = default(IBoard);
			var squareSelector = new SquareSelector();

			"Given that I have a board filled alphabetically and I have selected the centre square".Context(() =>
			                                                                                                	{
			                                                                                                		board = new BoardFactory().Create();			                                                                                                		
																													new AlphabeticalBoardFiller().Fill(board);																													
																													squareSelector.Select(board, 4, 4);
			                                                                                                	});
			"When I rotate the board left".Do(() => selectionRotator.Left(board));

			"Then square 4, 0 will contain letter Y".Observation(() => board[4, 0].Letter.Value.ShouldEqual('Y'));

			"Then square 3, 1 will contain letter B".Observation(() => board[3, 1].Letter.Value.ShouldEqual('B'));

			"Then square 4, 1 will contain letter X".Observation(() => board[4, 1].Letter.Value.ShouldEqual('X'));

			"Then square 5, 1 will contain letter D".Observation(() => board[5, 1].Letter.Value.ShouldEqual('D'));

			"Then square 2, 2 will contain letter E".Observation(() => board[2, 2].Letter.Value.ShouldEqual('E'));

			"Then square 3, 2 will contain letter F".Observation(() => board[3, 2].Letter.Value.ShouldEqual('F'));

			"Then square 4, 2 will contain letter W".Observation(() => board[4, 2].Letter.Value.ShouldEqual('W'));

			"Then square 5, 2 will contain letter H".Observation(() => board[5, 2].Letter.Value.ShouldEqual('H'));

			"Then square 6, 2 will contain letter I".Observation(() => board[6, 2].Letter.Value.ShouldEqual('I'));

			"Then square 1, 3 will contain letter J".Observation(() => board[1, 3].Letter.Value.ShouldEqual('J'));

			"Then square 2, 3 will contain letter K".Observation(() => board[2, 3].Letter.Value.ShouldEqual('K'));

			"Then square 3, 3 will contain letter L".Observation(() => board[3, 3].Letter.Value.ShouldEqual('L'));

			"Then square 4, 3 will contain letter V".Observation(() => board[4, 3].Letter.Value.ShouldEqual('V'));

			"Then square 5, 3 will contain letter N".Observation(() => board[5, 3].Letter.Value.ShouldEqual('N'));

			"Then square 6, 3 will contain letter O".Observation(() => board[6, 3].Letter.Value.ShouldEqual('O'));

			"Then square 7, 3 will contain letter P".Observation(() => board[7, 3].Letter.Value.ShouldEqual('P'));

			"Then square 0, 4 will contain letter A".Observation(() => board[0, 4].Letter.Value.ShouldEqual('A'));

			"Then square 1, 4 will contain letter C".Observation(() => board[1, 4].Letter.Value.ShouldEqual('C'));

			"Then square 2, 4 will contain letter G".Observation(() => board[2, 4].Letter.Value.ShouldEqual('G'));

			"Then square 3, 4 will contain letter M".Observation(() => board[3, 4].Letter.Value.ShouldEqual('M'));

			"Then square 4, 4 will contain letter U".Observation(() => board[4, 4].Letter.Value.ShouldEqual('U'));

			"Then square 5, 4 will contain letter C".Observation(() => board[5, 4].Letter.Value.ShouldEqual('C'));

			"Then square 6, 4 will contain letter I".Observation(() => board[6, 4].Letter.Value.ShouldEqual('I'));

			"Then square 7, 4 will contain letter M".Observation(() => board[7, 4].Letter.Value.ShouldEqual('M'));

			"Then square 8, 4 will contain letter O".Observation(() => board[8, 4].Letter.Value.ShouldEqual('O'));

			"Then square 1, 5 will contain letter Z".Observation(() => board[1, 5].Letter.Value.ShouldEqual('Z'));

			"Then square 2, 5 will contain letter A".Observation(() => board[2, 5].Letter.Value.ShouldEqual('A'));

			"Then square 3, 5 will contain letter B".Observation(() => board[3, 5].Letter.Value.ShouldEqual('B'));

			"Then square 4, 5 will contain letter T".Observation(() => board[4, 5].Letter.Value.ShouldEqual('T'));

			"Then square 5, 5 will contain letter D".Observation(() => board[5, 5].Letter.Value.ShouldEqual('D'));

			"Then square 6, 5 will contain letter E".Observation(() => board[6, 5].Letter.Value.ShouldEqual('E'));

			"Then square 7, 5 will contain letter F".Observation(() => board[7, 5].Letter.Value.ShouldEqual('F'));

			"Then square 2, 6 will contain letter G".Observation(() => board[2, 6].Letter.Value.ShouldEqual('G'));

			"Then square 3, 6 will contain letter H".Observation(() => board[3, 6].Letter.Value.ShouldEqual('H'));

			"Then square 4, 6 will contain letter S".Observation(() => board[4, 6].Letter.Value.ShouldEqual('S'));

			"Then square 5, 6 will contain letter J".Observation(() => board[5, 6].Letter.Value.ShouldEqual('J'));

			"Then square 6, 6 will contain letter K".Observation(() => board[6, 6].Letter.Value.ShouldEqual('K'));
			
			"Then square 3, 7 will contain letter L".Observation(() => board[3, 7].Letter.Value.ShouldEqual('L'));

			"Then square 4, 7 will contain letter R".Observation(() => board[4, 7].Letter.Value.ShouldEqual('R'));

			"Then square 5, 7 will contain letter N".Observation(() => board[5, 7].Letter.Value.ShouldEqual('N'));

			"Then square 4, 8 will contain letter Q".Observation(() => board[4, 8].Letter.Value.ShouldEqual('Q'));
		}

		[Specification]
		public void CanRotateASmallSelectionLeft()
		{
			var selectionRotator = new SelectionRotatator();
			var board = default(IBoard);
			var squareSelector = new SquareSelector();

			"Given that I have a board filled alphabetically and I have selected the square 5, 2".Context(() =>
			{
				board = new BoardFactory().Create();
				new AlphabeticalBoardFiller().Fill(board);
				squareSelector.Select(board, 5, 2);
			});

			"When I rotate the board left".Do(() => selectionRotator.Left(board));

			"Then square 4, 1 will contain letter C".Observation(() => board[4, 1].Letter.Value.ShouldEqual('C'));

			"Then square 5, 1 will contain letter I".Observation(() => board[5, 1].Letter.Value.ShouldEqual('I'));

			"Then square 4, 2 will contain letter D".Observation(() => board[4, 2].Letter.Value.ShouldEqual('D'));

			"Then square 5, 2 will contain letter H".Observation(() => board[5, 2].Letter.Value.ShouldEqual('H'));

			"Then square 4, 3 will contain letter M".Observation(() => board[4, 3].Letter.Value.ShouldEqual('M'));

			"Then square 5, 3 will contain letter G".Observation(() => board[5, 3].Letter.Value.ShouldEqual('G'));

			"Then square 6, 3 will contain letter O".Observation(() => board[6, 3].Letter.Value.ShouldEqual('O'));

			"Then square 7, 3 will contain letter P".Observation(() => board[7, 3].Letter.Value.ShouldEqual('P'));

		}
	}
}