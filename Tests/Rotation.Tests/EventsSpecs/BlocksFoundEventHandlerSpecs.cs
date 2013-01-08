using System.Collections.Generic;
using System.Linq;
using FakeItEasy;
using Rotation.Blocks;
using Rotation.Drawing.Animations;
using Rotation.EventHandlers;
using Rotation.Events;
using Rotation.GameControl;
using Rotation.StandardBoard;
using SubSpec;

namespace Rotation.GameObjects.sTests.EventsSpecs
{
    public class BlocksFoundEventHandlerSpecs
    {
        [Specification]
        public void CorrectAnimationGetsAddedToStore()
        {

            var animationStore = default(IAnimationStore);
            var eventHandler = default(BlocksFoundEventHandler);
            var fakeScoreManager = default(IScoreManager);
            var fakeLevelManger = default(ILevelManager);
            var blocks = default(IEnumerable<Block>);

            "Given I have an empty animation store and a blocks found event handler".Context(() =>
                {
                    animationStore = new SingleAnimationStore();
                    fakeScoreManager = A.Fake<IScoreManager>();
                    fakeLevelManger = A.Fake<ILevelManager>();
                    eventHandler = new BlocksFoundEventHandler(animationStore, A.Fake<IBoard>(), fakeScoreManager,
                                                               fakeLevelManger);

                    blocks = new[]{ new Block(new BoardCoordinate[]{}), };
                });

            "When I handle the blocks found event"
                .Do(() => eventHandler.Handle(new BlocksFoundEvent(blocks)));

            "Then 1 item should be in the animation store".Observation(
                () => animationStore.GetCurrentAnimations().Count().ShouldEqual(1));

            "Then the item in the animation store should be a blocks found animation"
                .Observation(() => animationStore.GetCurrentAnimations().First().ShouldBeOfType<BlocksFoundAnimation>());

            "Then the update score should be called on the score manager"
                .Observation(() => A.CallTo(() => fakeScoreManager.GetScore()).MustHaveHappened());

            "Then the update progress level should be called on the level manager"
                .Observation(() => A.CallTo(() => fakeLevelManger.UpdateProgress(A<IScore>.Ignored)).MustHaveHappened());

        }
    }
}