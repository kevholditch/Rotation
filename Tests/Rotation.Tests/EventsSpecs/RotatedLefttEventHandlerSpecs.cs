using System.Linq;
using FakeItEasy;
using Rotation.GameObjects.Drawing.Animations;
using Rotation.GameObjects.EventHandlers;
using Rotation.GameObjects.Events;
using Rotation.GameObjects.StandardBoard;
using Rotation.Tests.Common;
using SubSpec;

namespace Rotation.GameObjects.sTests.EventsSpecs
{
    public class RotatedLefttEventHandlerSpecs
    {
        [Specification]
        public void CorrectAnimationGetsAddedToStore()
        {

            var animationStore = default(IAnimationStore);
            var eventHandler = default(RotatedLeftEventHandler);

            "Given I have an empty animation store and a rotated left event handler".Context(() =>
                                                                                                 {
                                                                                                     animationStore = new SingleAnimationStore();
                                                                                                     eventHandler = new RotatedLeftEventHandler(animationStore, A.Fake<IBoard>());
                                                                                                 });

            "When I handle the rotated left event".Do(() => eventHandler.Handle(new RotatedLeftEvent(){ BoardCoordinates = new BoardCoordinate[] { } }));

            "Then 1 item should be in the animation store".Observation(
                () => animationStore.GetCurrentAnimations().Count().ShouldEqual(1));

            "Then the item in the animation store should be a rotate left animation".Observation(
                () => animationStore.GetCurrentAnimations().First().ShouldBeOfType<RotateLeftAnimation>());


        }
    }
}