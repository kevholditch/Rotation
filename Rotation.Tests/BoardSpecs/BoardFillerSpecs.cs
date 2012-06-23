﻿using FakeItEasy;
using Rotation.GameObjects.Board;
using Rotation.GameObjects.Letters;
using Rotation.GameObjects.Tiles;
using Rotation.Tests.Common;
using SubSpec;
using System.Linq;

namespace Rotation.GameObjects.sTests.BoardSpecs
{
	public class BoardFillerSpecs
	{
		[Specification]
		public void CanFillAnEmptyBoard()
		{
			var boardFiller = default(BoardFiller);
			var board = default(Board.Board);

			"Given that I have a board with with 41 selectable squares".Context(() =>
			                                                                    	{
			                                                                    		var fakeTileFactory = A.Fake<ITileFactory>();
			                                                                    		A.CallTo(() => fakeTileFactory.Create()).
			                                                                    			Returns(new StandardTile(new Letter(1, 'C')));

																						boardFiller = new BoardFiller(fakeTileFactory);
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