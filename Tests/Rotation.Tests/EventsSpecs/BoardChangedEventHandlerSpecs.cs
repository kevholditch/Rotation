using System.Collections.Generic;
using System.Linq;
using FakeItEasy;
using Rotation.GameObjects.EventHandlers;
using Rotation.GameObjects.Events;
using Rotation.GameObjects.StandardBoard;
using Rotation.GameObjects.Words;
using Rotation.GameObjects.sTests.Extensions;
using Rotation.GameObjects.sTests.TestClasses;
using Rotation.Tests.Common.Builders;
using SubSpec;
using Rotation.Tests.Common;

namespace Rotation.GameObjects.sTests.EventsSpecs
{
    public class BoardChangedEventHandlerSpecs
    {
        [Specification]
        public void CanRaiseAWordsFoundEvent()
        {
            var result = default(IGameEvent);
            var eventHandler = default(BoardChangedEventHandler);

            "Given I have a board changed event handler".Context(() =>
                {

                    GameEvents.Dispatcher = new ActionEventDispatcher(a => result = a);

                    var wordChecker = A.Fake<IWordChecker>();
                    A.CallTo(() => wordChecker.Check(A<IEnumerable<IEnumerable<Square>>>.Ignored)).Returns(
                        new List<IWord> {new Word(new[] {BuildA.DefaultSquare().WithLetter(0, 'K').Build()})});

                    eventHandler = new BoardChangedEventHandler(wordChecker, A.Fake<IBoard>());
                });

            "When I handle a board changed event".Do(() => eventHandler.Handle(new BoardChangedEvent()));

            "Then a word found event should be raised".Observation(() => result.ShouldBeOfType<WordsFoundEvent>());

            "Then there should be two words on the event".Observation(
                () => ((WordsFoundEvent) result).Words.Count().ShouldEqual(2));

            "Then the first word should be K".Observation(
                () => ((WordsFoundEvent) result).Words.First().Value.ShouldEqual("K"));

            "Then the second word should be K".Observation(
                () => ((WordsFoundEvent)result).Words.Second().Value.ShouldEqual("K"));



        }

        [Specification]
        public void CanCheckBoardWithNoKnownWords()
        {
            var result = default(IGameEvent);
            var eventHandler = default(BoardChangedEventHandler);

            "Given I have a board changed event handler".Context(() =>
                {

                    GameEvents.Dispatcher = new ActionEventDispatcher(a => result = a);

                    var wordChecker = A.Fake<IWordChecker>();
                    A.CallTo(() => wordChecker.Check(A<IEnumerable<IEnumerable<Square>>>.Ignored))
                        .Returns(new List<IWord>());

                    eventHandler = new BoardChangedEventHandler(wordChecker, A.Fake<IBoard>());
                });

            "When I handle the board changed event".Do(() => eventHandler.Handle(new BoardChangedEvent()));

            "Then no event should be raised".Observation(() => result.ShouldBeNull());

        }
    }
}
