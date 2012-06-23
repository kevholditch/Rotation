using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rotation.GameObjects.Letters;
using Rotation.GameObjects.StandardBoard;
using Rotation.GameObjects.StandardBoard.Rotation;
using Rotation.GameObjects.StandardBoard.Selection;
using Rotation.GameObjects.Tiles;

namespace ConsoleTestHarness
{
	class Program
	{
		static void Main(string[] args)
		{

			Board board = new BoardFactory().Create();

			var display = new ConsoleBoardDisplayer(board);

			display.Display();
			
			Console.ReadKey();

			display.ShowSelectableSquares();

			Console.ReadKey();

			var boardFiller = new BoardFiller(new StandardTileFactory(new LetterLookup()));

			boardFiller.Fill(board);

			display.Display();

		    Console.ReadKey();

		    var tileSelector = new SquareSelector();

            tileSelector.Select(board, 3, 3);

		    var selectionRotator = new SelectionRotatator();

            selectionRotator.Left(board);

            display.Display();


			Console.ReadKey();
		}
	}
}
