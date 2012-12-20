using System;
using System.Collections.Generic;
using FakeItEasy;
using Microsoft.Xna.Framework;
using Rotation.Blocks;
using Rotation.Constants;
using Rotation.Drawing.Animations;
using Rotation.Events;
using Rotation.GameObjects.sTests.TestClasses;
using Rotation.StandardBoard;
using SubSpec;
using System.Linq;

namespace Rotation.GameObjects.sTests.AnimationSpecs
{
    public class BlocksFoundAnimationSpecs
    {
        [Specification]
        public void CanSetIsInBlockToTrueForAllSquares()
        {
            var board = default(IBoard);
            var blocksFoundAnimation = default(BlocksFoundAnimation);
            var blocks = default(IEnumerable<Block>);

            "Given I have a blocks found event with a number of blocks found"
                .Context(() =>
                    {
                        board = new BoardFactory().Create();
                        var numericalBoardFiller = new NumericalBoardFiller(); 
                        numericalBoardFiller.Fill(board);
                        blocks =
                            new[]
                                {
                                    new Block(new[] {new BoardCoordinate(3, 3), new BoardCoordinate(3, 4)})
                                    , new Block(new[] {new BoardCoordinate(5, 5)})
                                };
                    });

            "When I initiate the animation"
                .Do(() => blocksFoundAnimation = new BlocksFoundAnimation(blocks, board));

            "Then the square at coordinate 3, 3 should be marked as in block"
                .Observation(() => board[3, 3].IsInBlock.ShouldBeTrue());

            "Then the square at coordinate 3, 4 should be marked as in block"
                .Observation(() => board[3, 4].IsInBlock.ShouldBeTrue());

            "Then the square at coordinate 5, 5 should be marked as in block"
                .Observation(() => board[5, 5].IsInBlock.ShouldBeTrue());


        }


        [Specification]
        public void CanAnimateAFrameWhenTimeHasNotElasped()
        {
            var blocksFoundAnimation = default(BlocksFoundAnimation);

            "Given I have a blocks found animation"
                .Context(
                    () =>
                    blocksFoundAnimation = new BlocksFoundAnimation(A.Fake<IEnumerable<Block>>(), A.Fake<IBoard>()));

            "When I call animate before the time has elapsed"
                .Do(
                    () =>
                    blocksFoundAnimation.Animate(new GameTime
                        {
                            ElapsedGameTime =
                                TimeSpan.FromMilliseconds(GameConstants.Animation.BLOCK_FOUND_LIGHT_UP_DURATION - 1)
                        }));

            "Then the animation should not be finished"
                .Observation(() => blocksFoundAnimation.Finished().ShouldBeFalse());
        }

        [Specification]
        public void CanAnimateAFrameWhenTimeHasElasped()
        {
            var blocksFoundAnimation = default(BlocksFoundAnimation);

            "Given I have a blocks found animation"
                .Context(
                    () =>
                    blocksFoundAnimation = new BlocksFoundAnimation(A.Fake<IEnumerable<Block>>(), A.Fake<IBoard>()));

            "When I call animate after the time has elapsed"
                .Do(
                    () =>
                    blocksFoundAnimation.Animate(new GameTime
                    {
                        ElapsedGameTime =
                            TimeSpan.FromMilliseconds(GameConstants.Animation.BLOCK_FOUND_LIGHT_UP_DURATION + 1)
                    }));

            "Then the animation should be finished"
                .Observation(() => blocksFoundAnimation.Finished().ShouldBeTrue());
        }

        [Specification]
        public void CanRaiseARemoveFoundBlocksEventWhenAnimationHasFinished()
        {
            var blocksFoundAnimation = default(BlocksFoundAnimation);
            var result = default(IGameEvent);
        	var board = default(IBoard);

            "Given I have a blocks found event with a number of blocks found"
                .Context(() =>
                    {
                        var blocks =
                            new[]
                                {
                                    new Block(new[] {new BoardCoordinate(3, 3), new BoardCoordinate(3, 4)})
                                    , new Block(new[] {new BoardCoordinate(5, 5), new BoardCoordinate(3, 4) })
                                };

                    	board = new BoardFactory().Create();
                    	var numericalBoardFiller = new NumericalBoardFiller();
						numericalBoardFiller.Fill(board);

                        blocksFoundAnimation = new BlocksFoundAnimation(blocks, board);
                        
                        GameEvents.Dispatcher = new ActionEventDispatcher(e => result = e);
                    });

            "When I call OnFinshed on the animation"
                .Do(() => blocksFoundAnimation.OnFinished());

            "Then the event raised should be a remove found blocks event"
                .Observation(() => result.ShouldBeOfType<RemoveFoundBlocksEvent>());

            "Then there should be 3 squares on the remove found blocks event"
                .Observation(() => ((RemoveFoundBlocksEvent) result).SquaresInBlocks
                    .Count.ShouldEqual(3));

            "Then there should be 1 square with cooardinates 3, 3"
                .Observation(() => ((RemoveFoundBlocksEvent) result).SquaresInBlocks
                    .Count(c => c.X == 3 && c.Y == 3).ShouldEqual(1));

            "Then there should be 1 square with cooardinates 3, 4"
                .Observation(() =>((RemoveFoundBlocksEvent)result).SquaresInBlocks
                    .Count(c => c.X == 3 && c.Y == 4).ShouldEqual(1));


            "Then there should be 1 square with cooardinates 5, 5"
                .Observation(() => ((RemoveFoundBlocksEvent)result).SquaresInBlocks
                    .Count(c => c.X == 5 && c.Y == 5).ShouldEqual(1));

        	"Then there should be no squares in blocks"
        		.Observation(() => board.AllSquares().Count(sq => sq.IsInBlock).ShouldEqual(0));


        }

    }
}