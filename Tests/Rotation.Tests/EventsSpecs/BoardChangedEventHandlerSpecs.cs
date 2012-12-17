using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FakeItEasy;
using Rotation.Blocks;
using Rotation.EventHandlers;
using Rotation.Events;
using Rotation.GameObjects.sTests.TestClasses;
using Rotation.StandardBoard;
using SubSpec;

namespace Rotation.GameObjects.sTests.EventsSpecs
{
    public class BoardChangedEventHandlerSpecs
    {
        [Specification]
        public void WontRaiseBlockFoundEventIfNoBlocksAreFound()
        {
            var boardChangedEventHandler = default(BoardChangedEventHandler);
            var result = default(IGameEvent);

            "Given I have a board with no blocks".Context(() =>
            {
                var fakeBlockFinder = A.Fake<IBlockFinder>();
                A.CallTo(() => fakeBlockFinder.Find(A<IBoard>.Ignored)).Returns(new Block[] { });

                boardChangedEventHandler = new BoardChangedEventHandler(A.Fake<IBoard>(), fakeBlockFinder);

                GameEvents.Dispatcher = new ActionEventDispatcher(g => result = g);

            });

            "When I handle a board changed event"
                .Do(() => boardChangedEventHandler.Handle(new BoardChangedEvent()));

            "Then no event should have been raised"
                .Observation(() => result.ShouldBeNull());
        }

        [Specification]
        public void CanRaiseABlocksFoundEventIfOneBlockIsFound()
        {
            var boardChangedEventHandler = default(BoardChangedEventHandler);
            var result = default(IGameEvent);

            "Given I have a board with 1 block".Context(() =>
                {
                    var fakeBlockFinder = A.Fake<IBlockFinder>();
                    A.CallTo(() => fakeBlockFinder.Find(A<IBoard>.Ignored)).Returns(new[]{ new Block(new Square[] { }) });

                    boardChangedEventHandler = new BoardChangedEventHandler(A.Fake<IBoard>(), fakeBlockFinder);

                    GameEvents.Dispatcher = new ActionEventDispatcher(g => result = g);
                });

            "When I handle a board changed event"
                .Do(() => boardChangedEventHandler.Handle(new BoardChangedEvent()));

            "Then a BlocksFoundEvent should be raised"
                .Observation(() => result.ShouldBeOfType<BlocksFoundEvent>());

            "Then there should be 1 found block on the event"
                .Observation(() => ((BlocksFoundEvent) result).Blocks.Count().ShouldEqual(1));

        }

        [Specification]
        public void CanRaiseABlocksFoundEventWhenMulitpleBlocksAreFound()
        {
            var boardChangedEventHandler = default(BoardChangedEventHandler);
            var result = default(IGameEvent);

            "Given I have a board with multiple blocks".Context(() =>
            {
                var fakeBlockFinder = A.Fake<IBlockFinder>();
                A.CallTo(() => fakeBlockFinder.Find(A<IBoard>.Ignored))
                 .Returns(new[] {new Block(new Square[] {}), new Block(new Square[] {})});

                boardChangedEventHandler = new BoardChangedEventHandler(A.Fake<IBoard>(), fakeBlockFinder);

                GameEvents.Dispatcher = new ActionEventDispatcher(g => result = g);
            });

            "When I handle a board changed event"
                .Do(() => boardChangedEventHandler.Handle(new BoardChangedEvent()));

            "Then a BlocksFoundEvent should be raised"
                .Observation(() => result.ShouldBeOfType<BlocksFoundEvent>());

            "Then there should be 2 found blocks on the event"
                .Observation(() => ((BlocksFoundEvent)result).Blocks.Count().ShouldEqual(2));

            
        }

        
    }
}
