using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Rotation.Constants;
using Rotation.Drawing.Animations;
using Rotation.StandardBoard;
using SubSpec;

namespace Rotation.GameObjects.sTests.AnimationSpecs
{
	public class BlocksFallingAnimationSpecs
	{
		[Specification]
		public void EachAnimationWillDecreaseTheOffset()
		{
			var board = default(IBoard);
			var blocksFallingAnimation = default(BlocksFallingAnimation);

			"Given I have a standard board and a known list of coordinates".Context(() =>
			{
				board = new BoardFactory().Create();
				var boardCoordinates = new List<BoardCoordinate> { new BoardCoordinate(1, 2), new BoardCoordinate(2, 3) };
				board[1, 2].YOffset = 200;
				board[2, 3].YOffset = 200;
				blocksFallingAnimation = new BlocksFallingAnimation(boardCoordinates, board);
			});

			"When I call animate after 100 milliseconds has passed"
				.Do(() => blocksFallingAnimation.Animate(new GameTime { ElapsedGameTime = TimeSpan.FromMilliseconds(100) }));

			"Then the square at 1, 2 should have a yoffset of 200 - block fall speed * 100".Observation(
				() => board[1, 2].YOffset.ShouldEqual((float)(200 - GameConstants.Animation.BLOCK_FALL_SPEED * 100)));

			"Then the square at 2, 3 should have a yoffset of 200 - block fall speed * 100".Observation(
				() => board[1, 2].YOffset.ShouldEqual((float)(200 - GameConstants.Animation.BLOCK_FALL_SPEED * 100)));
			

			"Then 2 squares will have a y offset higher than 0".Observation(
				() => board.AllSquares().Count(sq => sq.YOffset != 0).ShouldEqual(2));

		}

		public void CanTellWhenTheAnimationShouldFinish()
		{
			
		}

		public void CanRaiseABoardChangedEventWhenAnimationHasFinished()
		{
			
		}
		


	}
}