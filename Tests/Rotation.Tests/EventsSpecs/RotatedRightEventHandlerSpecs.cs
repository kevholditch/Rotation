using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FakeItEasy;
using Rotation.Drawing.Animations;
using Rotation.EventHandlers;
using Rotation.Events;
using Rotation.StandardBoard;
using SubSpec;

namespace Rotation.GameObjects.sTests.EventsSpecs
{
    public class RotatedRightEventHandlerSpecs
    {
        [Specification]
        public void CorrectAnimationGetsAddedToStore()
        {

            var animationStore = default(IAnimationStore);
            var eventHandler = default(RotatedRightEventHandler);

            "Given I have an empty animation store and a rotated right event handler".Context(() =>
                {
                    animationStore = new SingleAnimationStore();
                    eventHandler = new RotatedRightEventHandler(animationStore, A.Fake<IBoard>());
                });

            "When I handle the rotated right event".Do(() => eventHandler.Handle(new RotatedRightEvent{BoardCoordinates = new BoardCoordinate[]{}}));

            "Then 1 item should be in the animation store".Observation(
                () => animationStore.GetCurrentAnimations().Count().ShouldEqual(1));

            "Then the item in the animation store should be a rotate right animation".Observation(
                () => animationStore.GetCurrentAnimations().First().ShouldBeOfType<RotateRightAnimation>());


        }
    }
}
