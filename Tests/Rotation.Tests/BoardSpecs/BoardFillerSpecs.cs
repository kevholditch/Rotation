﻿using FakeItEasy;
using Rotation.StandardBoard;
using Rotation.Tiles;
using SubSpec;
using System.Linq;

namespace Rotation.GameObjects.sTests.BoardSpecs
{
	public class BoardFillerSpecs
	{
		[Specification]
		public void CanFillAnEmptyBoard()
		{
			var boardFiller = default(StandardBoardFiller);
			var board = default(Board);

			"Given that I have a board with with 41 selectable squares".Context(() =>
			                                                                    	{
			                                                                    		var fakeTileFactory = A.Fake<ITileFactory>();
			                                                                    		A.CallTo(() => fakeTileFactory.Create()).
			                                                                    			Returns(new StandardTile(1));

																						boardFiller = new StandardBoardFiller(fakeTileFactory);
			                                                                    		board = new BoardFactory().Create();
			                                                                    	});

			"When I fill the board".Do(() => boardFiller.Fill(board));

			"Then every square that is not selectable should not contain a tile".Observation(
				() => board.AllSquares().Where(sq => !sq.IsSelectable && sq.HasTile).Count().ShouldEqual(0));

			"Then every square that is selectable should contain a tile".Observation(
				() => board.AllSquares().Where(sq => sq.IsSelectable && sq.HasTile).Count().ShouldEqual(41));

		}


	}
}