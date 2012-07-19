using System.Collections.Generic;
using FakeItEasy;
using Rotation.GameObjects.Drawing.Animations;
using SubSpec;
using System.Linq;
using Rotation.Tests.Common;

namespace Rotation.GameObjects.sTests.AnimationSpecs
{
    public class AnimationStoreSpecs
    {
        [Specification]
        public void CanAddAnAnimationToTheAnimationStore()
        {
            var animationStore = default(SingleAnimationStore);
            var result = default (IEnumerable<IAnimation>);
            var animation = default(IAnimation);

            "Given I have added an animation to the animation store".Context(() =>
                {
                    animationStore = new SingleAnimationStore();
                    animation = A.Fake<IAnimation>();
                    animationStore.Add(animation);
                });

            "When I get the current animation items".Do(() => result = animationStore.GetCurrentAnimations());

            "Then 1 animation should be returned".Observation(() => result.Count().ShouldEqual(1));

            "Then the instance returned should be the same".Observation(
                () => result.First().ShouldBeTheSameAs(animation));
        }

        [Specification]
        public void CanRemoveAnAnimationToTheAnimationStore()
        {
            var animationStore = default(SingleAnimationStore);
            var result = default(IEnumerable<IAnimation>);

            "Given I have added an animation and then removed an animation to the animation store".Context(() =>
            {
                animationStore = new SingleAnimationStore();
                IAnimation animation = A.Fake<IAnimation>();
                animationStore.Add(animation);
                animationStore.Remove(animation);
            });

            "When I remove the animation".Do(() => result = animationStore.GetCurrentAnimations());

            "Then 0 animations should be returned".Observation(() => result.Count().ShouldEqual(0));

        }
    }
}
