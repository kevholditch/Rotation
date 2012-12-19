using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FakeItEasy;
using Rotation.Constants;
using Rotation.Drawing.Animations;
using Rotation.Engine;
using Rotation.EventHandlers;
using Rotation.Events;
using Rotation.GameObjects.sTests.BlockSpecs;
using Rotation.GameObjects.sTests.TestClasses;
using Rotation.StandardBoard;
using Rotation.Tiles;
using SubSpec;

namespace Rotation.GameObjects.sTests.EventsSpecs
{
    public class RemoveFoundBlocksEventHandlerSpecs
    {
        [Specification]
        public void CanCorrectlyRemoveFoundBlocksWhenOneBlockFound()
        {
            var board = default(IBoard);
            var handler = default(RemoveFoundBlocksEventHandler);
            var removeBlocksEvent = default(RemoveFoundBlocksEvent);
            var animationStore = default(IAnimationStore);
            

            "Given I have a an event with one block found"
                .Context(() =>
                    {
                        board = new BoardFactory().Create();
                        var numericalBoardFiller = new NumericalBoardFiller();
                        numericalBoardFiller.Fill(board);
                        animationStore = new SingleAnimationStore();
                        handler = new RemoveFoundBlocksEventHandler(board, animationStore, new MinusOneColourBoardFiller());
                        removeBlocksEvent = new RemoveFoundBlocksEvent(new List<BoardCoordinate>()
                            {new BoardCoordinate(4, 5), new BoardCoordinate(5, 5),
                             new BoardCoordinate(4, 6), new BoardCoordinate(5, 6)}); 
                    });

            "When I handle the event"
                .Do(() => handler.Handle(removeBlocksEvent));


            "Then there should be 1 animation in the animation store"
                .Observation(() => animationStore.GetCurrentAnimations().Count().ShouldEqual(1));

            "Then a blocks falling animtion is added to the animation store"
                .Observation(
                    () => animationStore.GetCurrentAnimations().First().ShouldBeOfType<BlocksFallingAnimation>());

            "Then there should be 14 squares to animate on the blocks falling animation"
                .Observation(() => ((BlocksFallingAnimation) animationStore.GetCurrentAnimations().First())
                                       .SquaresToAnimate.Count.ShouldEqual(14));

            "Then there should be 1 square to animate at 4, 6"
                .Observation(() => ((BlocksFallingAnimation)animationStore.GetCurrentAnimations().First())
                     .SquaresToAnimate.Count(sq => sq.X == 4 && sq.Y == 6).ShouldEqual(1));

            "Then there should be 1 square to animate at 4, 5"
                .Observation(() => ((BlocksFallingAnimation)animationStore.GetCurrentAnimations().First())
                     .SquaresToAnimate.Count(sq => sq.X == 4 && sq.Y == 5).ShouldEqual(1));

            "Then there should be 1 square to animate at 4, 4"
                .Observation(() => ((BlocksFallingAnimation)animationStore.GetCurrentAnimations().First())
                     .SquaresToAnimate.Count(sq => sq.X == 4 && sq.Y == 4).ShouldEqual(1));

            "Then there should be 1 square to animate at 4, 3"
                .Observation(() => ((BlocksFallingAnimation)animationStore.GetCurrentAnimations().First())
                     .SquaresToAnimate.Count(sq => sq.X == 4 && sq.Y == 3).ShouldEqual(1));

            "Then there should be 1 square to animate at 4, 2"
                .Observation(() => ((BlocksFallingAnimation)animationStore.GetCurrentAnimations().First())
                     .SquaresToAnimate.Count(sq => sq.X == 4 && sq.Y == 2).ShouldEqual(1));

            "Then there should be 1 square to animate at 4, 1"
                .Observation(() => ((BlocksFallingAnimation)animationStore.GetCurrentAnimations().First())
                     .SquaresToAnimate.Count(sq => sq.X == 4 && sq.Y == 1).ShouldEqual(1));

            "Then there should be 1 square to animate at 4, 0"
                .Observation(() => ((BlocksFallingAnimation)animationStore.GetCurrentAnimations().First())
                     .SquaresToAnimate.Count(sq => sq.X == 4 && sq.Y == 0).ShouldEqual(1));

            "Then there should be 1 square to animate at 5, 6"
                .Observation(() => ((BlocksFallingAnimation)animationStore.GetCurrentAnimations().First())
                     .SquaresToAnimate.Count(sq => sq.X == 5 && sq.Y == 6).ShouldEqual(1));

            "Then there should be 1 square to animate at 5, 5"
               .Observation(() => ((BlocksFallingAnimation)animationStore.GetCurrentAnimations().First())
                    .SquaresToAnimate.Count(sq => sq.X == 5 && sq.Y == 5).ShouldEqual(1));

            "Then there should be 1 square to animate at 5, 4"
               .Observation(() => ((BlocksFallingAnimation)animationStore.GetCurrentAnimations().First())
                    .SquaresToAnimate.Count(sq => sq.X == 5 && sq.Y == 4).ShouldEqual(1));

            "Then there should be 1 square to animate at 5, 3"
               .Observation(() => ((BlocksFallingAnimation)animationStore.GetCurrentAnimations().First())
                    .SquaresToAnimate.Count(sq => sq.X == 5 && sq.Y == 3).ShouldEqual(1));

            "Then there should be 1 square to animate at 5, 2"
               .Observation(() => ((BlocksFallingAnimation)animationStore.GetCurrentAnimations().First())
                    .SquaresToAnimate.Count(sq => sq.X == 5 && sq.Y == 2).ShouldEqual(1));

            "Then there should be 1 square to animate at 5, 1"
               .Observation(() => ((BlocksFallingAnimation)animationStore.GetCurrentAnimations().First())
                    .SquaresToAnimate.Count(sq => sq.X == 5 && sq.Y == 1).ShouldEqual(1));

            "Then there should be 1 square to animate at 5, 0"
               .Observation(() => ((BlocksFallingAnimation)animationStore.GetCurrentAnimations().First())
                    .SquaresToAnimate.Count(sq => sq.X == 5 && sq.Y == 0).ShouldEqual(1));

            "Then square 4, 6 should contain colour 21"
                .Observation(() => board[4, 6].Colour.ShouldEqual(21));

            "Then square 4, 5 should contain colour 13"
                .Observation(() => board[4, 5].Colour.ShouldEqual(13));

            "Then square 4, 4 should contain colour 7"
                .Observation(() => board[4, 4].Colour.ShouldEqual(7));

            "Then square 4, 3 should contain colour 3"
                .Observation(() => board[4, 3].Colour.ShouldEqual(3));

            "Then square 4, 2 should contain colour 1"
                .Observation(() => board[4, 2].Colour.ShouldEqual(1));

            "Then square 4, 1 should contain colour -1"
                .Observation(() => board[4, 1].Colour.ShouldEqual(-1));

            "Then square 4, 0 should contain colour -1"
                .Observation(() => board[4, 0].Colour.ShouldEqual(-1));

            "Then square 5, 6 should contain colour 22"
                .Observation(() => board[5, 6].Colour.ShouldEqual(22));

            "Then square 5, 5 should contain colour 14"
                .Observation(() => board[5, 5].Colour.ShouldEqual(14));

            "Then square 5, 4 should contain colour 8"
                .Observation(() => board[5, 4].Colour.ShouldEqual(8));

            "Then square 5, 3 should contain colour 4"
                .Observation(() => board[5, 3].Colour.ShouldEqual(4));

            "Then square 5, 2 should contain colour 8"
                .Observation(() => board[5, 2].Colour.ShouldEqual(-1));

            "Then square 5, 1 should contain colour 4"
                .Observation(() => board[5, 1].Colour.ShouldEqual(-1));

            "Then there should be 14 squares with an offset"
                .Observation(() => board.AllSquares().Count(sq => sq.YOffset > 0).ShouldEqual(14));

            "Then the offset of square 4, 6 should be 2 * tile height"
                .Observation(() => board[4, 6].YOffset.ShouldEqual(2*DrawingConstants.Tiles.TILE_HEIGHT));

            "Then the offset of square 4, 5 should be 2 * tile height"
                .Observation(() => board[4, 5].YOffset.ShouldEqual(2 * DrawingConstants.Tiles.TILE_HEIGHT));

            "Then the offset of square 4, 4 should be 2 * tile height"
                .Observation(() => board[4, 4].YOffset.ShouldEqual(2 * DrawingConstants.Tiles.TILE_HEIGHT));

            "Then the offset of square 4, 3 should be 2 * tile height"
                .Observation(() => board[4, 3].YOffset.ShouldEqual(2 * DrawingConstants.Tiles.TILE_HEIGHT));

            "Then the offset of square 4, 2 should be 2 * tile height"
                .Observation(() => board[4, 2].YOffset.ShouldEqual(2 * DrawingConstants.Tiles.TILE_HEIGHT));

            "Then the offset of square 4, 1 should be 2 * tile height"
               .Observation(() => board[4, 1].YOffset.ShouldEqual(2 * DrawingConstants.Tiles.TILE_HEIGHT));

            "Then the offset of square 4, 0 should be 2 * tile height"
               .Observation(() => board[4, 0].YOffset.ShouldEqual(2 * DrawingConstants.Tiles.TILE_HEIGHT));

            "Then the offset of square 5, 6 should be 2 * tile height"
                .Observation(() => board[5, 6].YOffset.ShouldEqual(2 * DrawingConstants.Tiles.TILE_HEIGHT));

            "Then the offset of square 5, 5 should be 2 * tile height"
                .Observation(() => board[5, 5].YOffset.ShouldEqual(2 * DrawingConstants.Tiles.TILE_HEIGHT));

            "Then the offset of square 5, 4 should be 2 * tile height"
                .Observation(() => board[5, 4].YOffset.ShouldEqual(2 * DrawingConstants.Tiles.TILE_HEIGHT));

            "Then the offset of square 5, 3 should be 2 * tile height"
                .Observation(() => board[5, 3].YOffset.ShouldEqual(2 * DrawingConstants.Tiles.TILE_HEIGHT));

            "Then the offset of square 5, 2 should be 2 * tile height"
                .Observation(() => board[5, 2].YOffset.ShouldEqual(2 * DrawingConstants.Tiles.TILE_HEIGHT));

            "Then the offset of square 5, 1 should be 2 * tile height"
               .Observation(() => board[5, 1].YOffset.ShouldEqual(2 * DrawingConstants.Tiles.TILE_HEIGHT));

            "Then the offset of square 5, 0 should be 2 * tile height"
               .Observation(() => board[5, 0].YOffset.ShouldEqual(2 * DrawingConstants.Tiles.TILE_HEIGHT));



        }

        [Specification]
        public void CanCorrectlyRemoveFoundBlocksWhenMultipleBlocksFoundInSameColumn()
        {
            var board = default(IBoard);
            var handler = default(RemoveFoundBlocksEventHandler);
            var removeBlocksEvent = default(RemoveFoundBlocksEvent);
            var animationStore = default(IAnimationStore);


            "Given I have a an event with two blocks found"
                .Context(() =>
                {
                    board = new BoardFactory().Create();
                    var numericalBoardFiller = new NumericalBoardFiller();
                    numericalBoardFiller.Fill(board);
                    animationStore = new SingleAnimationStore();
                    handler = new RemoveFoundBlocksEventHandler(board, animationStore, new MinusOneColourBoardFiller());
                    removeBlocksEvent = new RemoveFoundBlocksEvent(new List<BoardCoordinate>()
                            {new BoardCoordinate(4, 5), new BoardCoordinate(5, 5),
                             new BoardCoordinate(4, 6), new BoardCoordinate(5, 6),
                             new BoardCoordinate(4, 2), new BoardCoordinate(5, 2),
                             new BoardCoordinate(4, 3), new BoardCoordinate(5, 3)});
                });

            "When I handle the event"
                .Do(() => handler.Handle(removeBlocksEvent));


            "Then there should be 1 animation in the animation store"
                .Observation(() => animationStore.GetCurrentAnimations().Count().ShouldEqual(1));

            "Then a blocks falling animtion is added to the animation store"
                .Observation(
                    () => animationStore.GetCurrentAnimations().First().ShouldBeOfType<BlocksFallingAnimation>());

            "Then there should be 14 squares to animate on the blocks falling animation"
                .Observation(() => ((BlocksFallingAnimation)animationStore.GetCurrentAnimations().First())
                                       .SquaresToAnimate.Count.ShouldEqual(14));

            "Then there should be 1 square to animate at 4, 6"
                .Observation(() => ((BlocksFallingAnimation)animationStore.GetCurrentAnimations().First())
                     .SquaresToAnimate.Count(sq => sq.X == 4 && sq.Y == 6).ShouldEqual(1));

            "Then there should be 1 square to animate at 4, 5"
                .Observation(() => ((BlocksFallingAnimation)animationStore.GetCurrentAnimations().First())
                     .SquaresToAnimate.Count(sq => sq.X == 4 && sq.Y == 5).ShouldEqual(1));

            "Then there should be 1 square to animate at 4, 4"
                .Observation(() => ((BlocksFallingAnimation)animationStore.GetCurrentAnimations().First())
                     .SquaresToAnimate.Count(sq => sq.X == 4 && sq.Y == 4).ShouldEqual(1));

            "Then there should be 1 square to animate at 4, 3"
                .Observation(() => ((BlocksFallingAnimation)animationStore.GetCurrentAnimations().First())
                     .SquaresToAnimate.Count(sq => sq.X == 4 && sq.Y == 3).ShouldEqual(1));

            "Then there should be 1 square to animate at 4, 2"
                .Observation(() => ((BlocksFallingAnimation)animationStore.GetCurrentAnimations().First())
                     .SquaresToAnimate.Count(sq => sq.X == 4 && sq.Y == 2).ShouldEqual(1));

            "Then there should be 1 square to animate at 4, 1"
                .Observation(() => ((BlocksFallingAnimation)animationStore.GetCurrentAnimations().First())
                     .SquaresToAnimate.Count(sq => sq.X == 4 && sq.Y == 1).ShouldEqual(1));

            "Then there should be 1 square to animate at 4, 0"
                .Observation(() => ((BlocksFallingAnimation)animationStore.GetCurrentAnimations().First())
                     .SquaresToAnimate.Count(sq => sq.X == 4 && sq.Y == 0).ShouldEqual(1));

            "Then there should be 1 square to animate at 5, 6"
                .Observation(() => ((BlocksFallingAnimation)animationStore.GetCurrentAnimations().First())
                     .SquaresToAnimate.Count(sq => sq.X == 5 && sq.Y == 6).ShouldEqual(1));

            "Then there should be 1 square to animate at 5, 5"
               .Observation(() => ((BlocksFallingAnimation)animationStore.GetCurrentAnimations().First())
                    .SquaresToAnimate.Count(sq => sq.X == 5 && sq.Y == 5).ShouldEqual(1));

            "Then there should be 1 square to animate at 5, 4"
               .Observation(() => ((BlocksFallingAnimation)animationStore.GetCurrentAnimations().First())
                    .SquaresToAnimate.Count(sq => sq.X == 5 && sq.Y == 4).ShouldEqual(1));

            "Then there should be 1 square to animate at 5, 3"
               .Observation(() => ((BlocksFallingAnimation)animationStore.GetCurrentAnimations().First())
                    .SquaresToAnimate.Count(sq => sq.X == 5 && sq.Y == 3).ShouldEqual(1));

            "Then there should be 1 square to animate at 5, 2"
               .Observation(() => ((BlocksFallingAnimation)animationStore.GetCurrentAnimations().First())
                    .SquaresToAnimate.Count(sq => sq.X == 5 && sq.Y == 2).ShouldEqual(1));

            "Then there should be 1 square to animate at 5, 1"
               .Observation(() => ((BlocksFallingAnimation)animationStore.GetCurrentAnimations().First())
                    .SquaresToAnimate.Count(sq => sq.X == 5 && sq.Y == 1).ShouldEqual(1));

            "Then there should be 1 square to animate at 5, 0"
               .Observation(() => ((BlocksFallingAnimation)animationStore.GetCurrentAnimations().First())
                    .SquaresToAnimate.Count(sq => sq.X == 5 && sq.Y == 0).ShouldEqual(1));

            "Then square 4, 6 should contain colour 21"
                .Observation(() => board[4, 6].Colour.ShouldEqual(21));

            "Then square 4, 5 should contain colour 3"
                .Observation(() => board[4, 5].Colour.ShouldEqual(3));

            "Then square 4, 4 should contain colour 1"
                .Observation(() => board[4, 4].Colour.ShouldEqual(1));

            "Then square 4, 3 should contain colour -1"
                .Observation(() => board[4, 3].Colour.ShouldEqual(-1));

            "Then square 4, 2 should contain colour -1"
                .Observation(() => board[4, 2].Colour.ShouldEqual(-1));

            "Then square 4, 1 should contain colour -1"
                .Observation(() => board[4, 1].Colour.ShouldEqual(-1));

            "Then square 4, 0 should contain colour -1"
                .Observation(() => board[4, 0].Colour.ShouldEqual(-1));

            "Then square 5, 6 should contain colour 22"
                .Observation(() => board[5, 6].Colour.ShouldEqual(22));

            "Then square 5, 5 should contain colour 4"
                .Observation(() => board[5, 5].Colour.ShouldEqual(4));

            "Then square 5, 4 should contain colour 22"
                .Observation(() => board[5, 4].Colour.ShouldEqual(-1));

            "Then square 5, 3 should contain colour -1"
                .Observation(() => board[5, 3].Colour.ShouldEqual(-1));

            "Then square 5, 2 should contain colour -1"
                .Observation(() => board[5, 2].Colour.ShouldEqual(-1));

            "Then square 5, 1 should contain colour -1"
                .Observation(() => board[5, 1].Colour.ShouldEqual(-1));

            "Then there should be 14 squares with an offset"
                .Observation(() => board.AllSquares().Count(sq => sq.YOffset > 0).ShouldEqual(14));

            "Then the offset of square 4, 6 should be 2 * tile height"
                .Observation(() => board[4, 6].YOffset.ShouldEqual(2 * DrawingConstants.Tiles.TILE_HEIGHT));

            "Then the offset of square 4, 5 should be 4 * tile height"
                .Observation(() => board[4, 5].YOffset.ShouldEqual(4 * DrawingConstants.Tiles.TILE_HEIGHT));

            "Then the offset of square 4, 4 should be 4 * tile height"
                .Observation(() => board[4, 4].YOffset.ShouldEqual(4 * DrawingConstants.Tiles.TILE_HEIGHT));

            "Then the offset of square 4, 3 should be 4 * tile height"
                .Observation(() => board[4, 3].YOffset.ShouldEqual(4 * DrawingConstants.Tiles.TILE_HEIGHT));

            "Then the offset of square 4, 2 should be 4 * tile height"
                .Observation(() => board[4, 2].YOffset.ShouldEqual(4 * DrawingConstants.Tiles.TILE_HEIGHT));

            "Then the offset of square 4, 1 should be 4 * tile height"
               .Observation(() => board[4, 1].YOffset.ShouldEqual(4 * DrawingConstants.Tiles.TILE_HEIGHT));

            "Then the offset of square 4, 0 should be 4 * tile height"
               .Observation(() => board[4, 0].YOffset.ShouldEqual(4 * DrawingConstants.Tiles.TILE_HEIGHT));

            "Then the offset of square 5, 6 should be 2 * tile height"
                .Observation(() => board[5, 6].YOffset.ShouldEqual(2 * DrawingConstants.Tiles.TILE_HEIGHT));

            "Then the offset of square 5, 5 should be 4 * tile height"
                .Observation(() => board[5, 5].YOffset.ShouldEqual(4 * DrawingConstants.Tiles.TILE_HEIGHT));

            "Then the offset of square 5, 4 should be 4 * tile height"
                .Observation(() => board[5, 4].YOffset.ShouldEqual(4 * DrawingConstants.Tiles.TILE_HEIGHT));

            "Then the offset of square 5, 3 should be 4 * tile height"
                .Observation(() => board[5, 3].YOffset.ShouldEqual(4 * DrawingConstants.Tiles.TILE_HEIGHT));

            "Then the offset of square 5, 2 should be 4 * tile height"
                .Observation(() => board[5, 2].YOffset.ShouldEqual(4 * DrawingConstants.Tiles.TILE_HEIGHT));

            "Then the offset of square 5, 1 should be 4 * tile height"
               .Observation(() => board[5, 1].YOffset.ShouldEqual(4 * DrawingConstants.Tiles.TILE_HEIGHT));

            "Then the offset of square 5, 0 should be 4 * tile height"
               .Observation(() => board[5, 0].YOffset.ShouldEqual(4 * DrawingConstants.Tiles.TILE_HEIGHT));


        }

        [Specification]
        public void CanCorrectlyRemoveFoundBlocksWhenMultipleBlocksFoundInDifferentColumns()
        {
            var board = default(IBoard);
            var handler = default(RemoveFoundBlocksEventHandler);
            var removeBlocksEvent = default(RemoveFoundBlocksEvent);
            var animationStore = default(IAnimationStore);


            "Given I have a an event with two blocks found"
                .Context(() =>
                {
                    board = new BoardFactory().Create();
                    var numericalBoardFiller = new NumericalBoardFiller();
                    numericalBoardFiller.Fill(board);
                    animationStore = new SingleAnimationStore();
                    handler = new RemoveFoundBlocksEventHandler(board, animationStore, new MinusOneColourBoardFiller());
                    removeBlocksEvent = new RemoveFoundBlocksEvent(new List<BoardCoordinate>()
                            {new BoardCoordinate(4, 5), new BoardCoordinate(5, 5),
                             new BoardCoordinate(4, 6), new BoardCoordinate(5, 6),
                             new BoardCoordinate(3, 2), new BoardCoordinate(4, 2),
                             new BoardCoordinate(3, 3), new BoardCoordinate(4, 3)});
                });

            "When I handle the event"
                .Do(() => handler.Handle(removeBlocksEvent));


            "Then there should be 1 animation in the animation store"
                .Observation(() => animationStore.GetCurrentAnimations().Count().ShouldEqual(1));

            "Then a blocks falling animtion is added to the animation store"
                .Observation(
                    () => animationStore.GetCurrentAnimations().First().ShouldBeOfType<BlocksFallingAnimation>());

            "Then there should be 18 squares to animate on the blocks falling animation"
                .Observation(() => ((BlocksFallingAnimation)animationStore.GetCurrentAnimations().First())
                                       .SquaresToAnimate.Count.ShouldEqual(18));

            "Then there should be 1 square to animate at 3, 3"
                .Observation(() => ((BlocksFallingAnimation)animationStore.GetCurrentAnimations().First())
                     .SquaresToAnimate.Count(sq => sq.X == 3 && sq.Y == 3).ShouldEqual(1));

            "Then there should be 1 square to animate at 3, 2"
                .Observation(() => ((BlocksFallingAnimation)animationStore.GetCurrentAnimations().First())
                     .SquaresToAnimate.Count(sq => sq.X == 3 && sq.Y == 2).ShouldEqual(1));

            "Then there should be 1 square to animate at 3, 1"
                .Observation(() => ((BlocksFallingAnimation)animationStore.GetCurrentAnimations().First())
                     .SquaresToAnimate.Count(sq => sq.X == 3 && sq.Y == 1).ShouldEqual(1));

            "Then there should be 1 square to animate at 3, 0"
                .Observation(() => ((BlocksFallingAnimation)animationStore.GetCurrentAnimations().First())
                     .SquaresToAnimate.Count(sq => sq.X == 3 && sq.Y == 0).ShouldEqual(1));

            "Then there should be 1 square to animate at 4, 6"
                .Observation(() => ((BlocksFallingAnimation)animationStore.GetCurrentAnimations().First())
                     .SquaresToAnimate.Count(sq => sq.X == 4 && sq.Y == 6).ShouldEqual(1));

            "Then there should be 1 square to animate at 4, 5"
                .Observation(() => ((BlocksFallingAnimation)animationStore.GetCurrentAnimations().First())
                     .SquaresToAnimate.Count(sq => sq.X == 4 && sq.Y == 5).ShouldEqual(1));

            "Then there should be 1 square to animate at 4, 4"
                .Observation(() => ((BlocksFallingAnimation)animationStore.GetCurrentAnimations().First())
                     .SquaresToAnimate.Count(sq => sq.X == 4 && sq.Y == 4).ShouldEqual(1));

            "Then there should be 1 square to animate at 4, 3"
                .Observation(() => ((BlocksFallingAnimation)animationStore.GetCurrentAnimations().First())
                     .SquaresToAnimate.Count(sq => sq.X == 4 && sq.Y == 3).ShouldEqual(1));

            "Then there should be 1 square to animate at 4, 2"
                .Observation(() => ((BlocksFallingAnimation)animationStore.GetCurrentAnimations().First())
                     .SquaresToAnimate.Count(sq => sq.X == 4 && sq.Y == 2).ShouldEqual(1));

            "Then there should be 1 square to animate at 4, 1"
                .Observation(() => ((BlocksFallingAnimation)animationStore.GetCurrentAnimations().First())
                     .SquaresToAnimate.Count(sq => sq.X == 4 && sq.Y == 1).ShouldEqual(1));

            "Then there should be 1 square to animate at 4, 0"
                .Observation(() => ((BlocksFallingAnimation)animationStore.GetCurrentAnimations().First())
                     .SquaresToAnimate.Count(sq => sq.X == 4 && sq.Y == 0).ShouldEqual(1));

            "Then there should be 1 square to animate at 5, 6"
                .Observation(() => ((BlocksFallingAnimation)animationStore.GetCurrentAnimations().First())
                     .SquaresToAnimate.Count(sq => sq.X == 5 && sq.Y == 6).ShouldEqual(1));

            "Then there should be 1 square to animate at 5, 5"
               .Observation(() => ((BlocksFallingAnimation)animationStore.GetCurrentAnimations().First())
                    .SquaresToAnimate.Count(sq => sq.X == 5 && sq.Y == 5).ShouldEqual(1));

            "Then there should be 1 square to animate at 5, 4"
               .Observation(() => ((BlocksFallingAnimation)animationStore.GetCurrentAnimations().First())
                    .SquaresToAnimate.Count(sq => sq.X == 5 && sq.Y == 4).ShouldEqual(1));

            "Then there should be 1 square to animate at 5, 3"
               .Observation(() => ((BlocksFallingAnimation)animationStore.GetCurrentAnimations().First())
                    .SquaresToAnimate.Count(sq => sq.X == 5 && sq.Y == 3).ShouldEqual(1));

            "Then there should be 1 square to animate at 5, 2"
               .Observation(() => ((BlocksFallingAnimation)animationStore.GetCurrentAnimations().First())
                    .SquaresToAnimate.Count(sq => sq.X == 5 && sq.Y == 2).ShouldEqual(1));

            "Then there should be 1 square to animate at 5, 1"
               .Observation(() => ((BlocksFallingAnimation)animationStore.GetCurrentAnimations().First())
                    .SquaresToAnimate.Count(sq => sq.X == 5 && sq.Y == 1).ShouldEqual(1));

            "Then there should be 1 square to animate at 5, 0"
               .Observation(() => ((BlocksFallingAnimation)animationStore.GetCurrentAnimations().First())
                    .SquaresToAnimate.Count(sq => sq.X == 5 && sq.Y == 0).ShouldEqual(1));

            "Then square 5, 3 should contain colour 12"
                .Observation(() => board[5, 3].Colour.ShouldEqual(12));

            "Then square 5, 2 should contain colour -1"
                .Observation(() => board[5, 2].Colour.ShouldEqual(-1));

            "Then square 5, 1 should contain colour -1"
                .Observation(() => board[5, 1].Colour.ShouldEqual(-1));

            "Then square 4, 6 should contain colour 21"
                .Observation(() => board[4, 6].Colour.ShouldEqual(21));

            "Then square 4, 5 should contain colour 3"
                .Observation(() => board[4, 5].Colour.ShouldEqual(3));

            "Then square 4, 4 should contain colour 1"
                .Observation(() => board[4, 4].Colour.ShouldEqual(-1));

            "Then square 4, 3 should contain colour -1"
                .Observation(() => board[4, 3].Colour.ShouldEqual(-1));

            "Then square 4, 2 should contain colour -1"
                .Observation(() => board[4, 2].Colour.ShouldEqual(-1));

            "Then square 4, 1 should contain colour -1"
                .Observation(() => board[4, 1].Colour.ShouldEqual(3));

            "Then square 4, 0 should contain colour -1"
                .Observation(() => board[4, 0].Colour.ShouldEqual(1));

            "Then square 5, 6 should contain colour 22"
                .Observation(() => board[5, 6].Colour.ShouldEqual(22));

            "Then square 5, 5 should contain colour 14"
                .Observation(() => board[5, 5].Colour.ShouldEqual(14));

            "Then square 5, 4 should contain colour 8"
                .Observation(() => board[5, 4].Colour.ShouldEqual(8));

            "Then square 5, 3 should contain colour -1"
                .Observation(() => board[5, 3].Colour.ShouldEqual(-1));

            "Then square 5, 2 should contain colour -1"
                .Observation(() => board[5, 2].Colour.ShouldEqual(-1));

            "Then square 5, 1 should contain colour -1"
                .Observation(() => board[5, 1].Colour.ShouldEqual(-1));

            "Then there should be 14 squares with an offset"
                .Observation(() => board.AllSquares().Count(sq => sq.YOffset > 0).ShouldEqual(14));

            "Then the offset of square 3, 3 should be 2 * tile height"
                .Observation(() => board[3, 3].YOffset.ShouldEqual(2 * DrawingConstants.Tiles.TILE_HEIGHT));

            "Then the offset of square 3, 2 should be 2 * tile height"
                .Observation(() => board[3, 2].YOffset.ShouldEqual(2 * DrawingConstants.Tiles.TILE_HEIGHT));

            "Then the offset of square 3, 1 should be 2 * tile height"
               .Observation(() => board[3, 1].YOffset.ShouldEqual(2 * DrawingConstants.Tiles.TILE_HEIGHT));

            "Then the offset of square 3, 0 should be 2 * tile height"
               .Observation(() => board[3, 0].YOffset.ShouldEqual(2 * DrawingConstants.Tiles.TILE_HEIGHT));

            "Then the offset of square 4, 6 should be 2 * tile height"
                .Observation(() => board[4, 6].YOffset.ShouldEqual(2 * DrawingConstants.Tiles.TILE_HEIGHT));

            "Then the offset of square 4, 5 should be 4 * tile height"
                .Observation(() => board[4, 5].YOffset.ShouldEqual(4 * DrawingConstants.Tiles.TILE_HEIGHT));

            "Then the offset of square 4, 4 should be 4 * tile height"
                .Observation(() => board[4, 4].YOffset.ShouldEqual(4 * DrawingConstants.Tiles.TILE_HEIGHT));

            "Then the offset of square 4, 3 should be 4 * tile height"
                .Observation(() => board[4, 3].YOffset.ShouldEqual(4 * DrawingConstants.Tiles.TILE_HEIGHT));

            "Then the offset of square 4, 2 should be 4 * tile height"
                .Observation(() => board[4, 2].YOffset.ShouldEqual(4 * DrawingConstants.Tiles.TILE_HEIGHT));

            "Then the offset of square 4, 1 should be 4 * tile height"
               .Observation(() => board[4, 1].YOffset.ShouldEqual(4 * DrawingConstants.Tiles.TILE_HEIGHT));

            "Then the offset of square 4, 0 should be 4 * tile height"
               .Observation(() => board[4, 0].YOffset.ShouldEqual(4 * DrawingConstants.Tiles.TILE_HEIGHT));

            "Then the offset of square 5, 6 should be 2 * tile height"
                .Observation(() => board[5, 6].YOffset.ShouldEqual(2 * DrawingConstants.Tiles.TILE_HEIGHT));

            "Then the offset of square 5, 5 should be 2 * tile height"
                .Observation(() => board[5, 5].YOffset.ShouldEqual(2 * DrawingConstants.Tiles.TILE_HEIGHT));

            "Then the offset of square 5, 4 should be 2 * tile height"
                .Observation(() => board[5, 4].YOffset.ShouldEqual(2 * DrawingConstants.Tiles.TILE_HEIGHT));

            "Then the offset of square 5, 3 should be 2 * tile height"
                .Observation(() => board[5, 3].YOffset.ShouldEqual(2 * DrawingConstants.Tiles.TILE_HEIGHT));

            "Then the offset of square 5, 2 should be 2 * tile height"
                .Observation(() => board[5, 2].YOffset.ShouldEqual(2 * DrawingConstants.Tiles.TILE_HEIGHT));

            "Then the offset of square 5, 1 should be 2 * tile height"
               .Observation(() => board[5, 1].YOffset.ShouldEqual(2 * DrawingConstants.Tiles.TILE_HEIGHT));

            "Then the offset of square 5, 0 should be 2 * tile height"
               .Observation(() => board[5, 0].YOffset.ShouldEqual(2 * DrawingConstants.Tiles.TILE_HEIGHT));

        }
    }

    public class MinusOneColourBoardFiller : IBoardFiller
    {
        public void Fill(IBoard board)
        {
            foreach (var square in board.AllSquares().Where(sq => sq.IsSelectable && !sq.HasTile))
            {
                square.Tile = new StandardTile(-1);
            }
        }
    }
}
