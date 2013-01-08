using System.Collections.Generic;
using FakeItEasy;
using Rotation.Events;
using Rotation.GameControl;
using Rotation.GameObjects.sTests.TestClasses;
using SubSpec;
using System.Linq;

namespace Rotation.GameObjects.sTests.GameControlSpecs
{
    public class LevelManagerSpecs
    {
        [Specification]
        public void CanInitialiseLevelManagerCorrectly()
        {
            var levelManager = default(LevelManager);
            var fakeScore = default(IScore);

            "Given I have a new LevelManager and 20 squares to go until the next level"
                .Context(() =>
                    {
                        var fakeNextLevel = A.Fake<INextLevel>();
                        A.CallTo(() => fakeNextLevel.AmountOfSquaresForLevelUp).Returns(20);
                        levelManager = new LevelManager(1, fakeNextLevel);
                        fakeScore = A.Fake<IScore>();
                        A.CallTo(() => fakeScore.TotalSquaresMade).Returns(12);
                    });

            "When I update the progress having made 12 squares"
                .Do(() => levelManager.UpdateProgress(fakeScore));

            "Then there should be 8 squares to go until the next level"
                .Observation(() => levelManager.SquaresToNextLevel.ShouldEqual(8));

            "Then the level should still be 1"
                .Observation(() => levelManager.Level.ShouldEqual(1));
        }

        [Specification]
        public void CanRaiseALevelUpEventWhenEnoughSquaresAreMade()
        {
            var levelManager = default(LevelManager);
            var fakeScore = default(IScore);
            var result = default(IGameEvent);

            "Given I have a LevelManager with 20 squares to go until the next level"
                .Context(() =>
                {
                    var fakeNextLevel = A.Fake<INextLevel>();
                    A.CallTo(() => fakeNextLevel.AmountOfSquaresForLevelUp).Returns(20);
                    levelManager = new LevelManager(1, fakeNextLevel);
                    fakeScore = A.Fake<IScore>();
                    A.CallTo(() => fakeScore.TotalSquaresMade).Returns(24);
                    GameEvents.Dispatcher = new ActionEventDispatcher(ge => result = ge);
                });

            "When I update the progress having made 24 squares"
                .Do(() => levelManager.UpdateProgress(fakeScore));

            "Then there should be 16 squares to go until the next level"
                .Observation(() => levelManager.SquaresToNextLevel.ShouldEqual(8));

            "Then the level should now be 2"
                .Observation(() => levelManager.Level.ShouldEqual(1));

            "Then the event raised should be a level up event"
                .Observation(() => result.ShouldBeOfType<LevelUpEvent>());

            "Then the level up event should have an old level of 1"
                .Observation(() => ((LevelUpEvent) result).OldLevel.ShouldEqual(1));

            "Then the level up event should have a new level of 2"
                .Observation(() => ((LevelUpEvent) result).NewLevel.ShouldEqual(2));

        }

        [Specification]
        public void CanUpdateLevelTwiceWhenSquaresAreEnoughToLevelUpTwice()
        {
            var levelManager = default(LevelManager);
            var fakeScore = default(IScore);
            var results = default(List<IGameEvent>);

            "Given I have a LevelManager with 20 squares to go until the next level"
                .Context(() =>
                {
                    var fakeNextLevel = A.Fake<INextLevel>();
                    A.CallTo(() => fakeNextLevel.AmountOfSquaresForLevelUp).Returns(20);
                    levelManager = new LevelManager(1, fakeNextLevel);
                    fakeScore = A.Fake<IScore>();
                    A.CallTo(() => fakeScore.TotalSquaresMade).Returns(46);
                    results = new List<IGameEvent>();
                    GameEvents.Dispatcher = new ActionEventDispatcher(ge => results.Add(ge));
                });

            "When I update the progress having made 46 squares"
                .Do(() => levelManager.UpdateProgress(fakeScore));

            "Then there should be 14 squares to go until the next level"
                .Observation(() => levelManager.SquaresToNextLevel.ShouldEqual(14));

            "Then the level should now be 3"
                .Observation(() => levelManager.Level.ShouldEqual(1));

            "Then there should be 2 level up events raised"
                .Observation(() => results.OfType<LevelUpEvent>().Count().ShouldEqual(2));

            "Then the first level up event should have an old level of 1"
                .Observation(() => ((LevelUpEvent)results[0]).OldLevel.ShouldEqual(1));

            "Then the first level up event should have a new level of 2"
                .Observation(() => ((LevelUpEvent)results[0]).NewLevel.ShouldEqual(2));

            "Then the second level up event should have an old level of 2"
                .Observation(() => ((LevelUpEvent)results[1]).OldLevel.ShouldEqual(2));

            "Then the second level up event should have a new level of 3"
                .Observation(() => ((LevelUpEvent)results[1]).NewLevel.ShouldEqual(3));
        }
    }
}