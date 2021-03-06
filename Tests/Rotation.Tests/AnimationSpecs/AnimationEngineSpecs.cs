﻿using System.Collections.Generic;
using FakeItEasy;
using Microsoft.Xna.Framework;
using Rotation.Drawing.Animations;
using SubSpec;

namespace Rotation.GameObjects.sTests.AnimationSpecs
{
    public class AnimationEngineSpecs
    {
        [Specification]
        public void AnimationEngineCallsAnimateOnAllCurrentAnimations()
        {
            var animationEngine = default(AnimationEngine);
            var animation = default(IAnimation);
            var animation2 = default(IAnimation);
            var gameTime = default(GameTime);

            "Given I have 2 animations in an animation store".Context(() =>
                {
                    animation = A.Fake<IAnimation>();
                    A.CallTo(() => animation.Finished()).Returns(false);
                
                    animation2 = A.Fake<IAnimation>();
                    A.CallTo(() => animation.Finished()).Returns(false);

                    var animationStore = A.Fake<IAnimationStore>();
                    A.CallTo(() => animationStore.GetCurrentAnimations())
                        .Returns(new List<IAnimation>(){ animation, animation2});
                    animationEngine = new AnimationEngine(animationStore);
                    gameTime = new GameTime();
                });

            "When I call run".Do(() => animationEngine.Run(gameTime));

            "Then animate should be called on the first animation".Observation(
                () => A.CallTo(() => animation.Animate(gameTime)).MustHaveHappened());
            
            "Then animate should be called on the second animation".Observation(
                () => A.CallTo(() => animation2.Animate(gameTime)).MustHaveHappened());

        }

        [Specification]
        public void AnimationRemovedFromTheStoreIfItHasFinished()
        {
            var animationEngine = default(AnimationEngine);
            var animationStore = default(IAnimationStore);

            "Given I have an animation that has finished".Context(() =>
                {
                    var animation = A.Fake<IAnimation>();
                    A.CallTo(() => animation.Finished()).Returns(true);
                    animationStore = A.Fake<IAnimationStore>();
                    A.CallTo(() => animationStore.GetCurrentAnimations())
                        .Returns(new List<IAnimation> {animation});

                    animationEngine = new AnimationEngine(animationStore);
                });

            "When I call run".Do(() => animationEngine.Run(new GameTime()));

            "Then the animation should be removed from the animation store".Observation(
                () => A.CallTo(() => animationStore.Remove(A<IAnimation>.Ignored)).MustHaveHappened());


        }
    }
}
