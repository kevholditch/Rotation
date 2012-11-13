using System;
using Microsoft.Xna.Framework;
using Rotation.Constants;
using Rotation.Drawing.Animations;
using Rotation.StandardBoard;
using Rotation.Words;
using SubSpec;

namespace Rotation.GameObjects.sTests.AnimationSpecs
{
    public class WordFoundAnimationSpecs
    {
        [Specification]
        public void WordFoundAnimationIsStillRunningIfTimeHasNotExpired()
        {
            var wordFoundAnimation = default(WordFoundAnimation);
            var gameTime = default(GameTime);

            "Given less game time than the animation time has elapsed".Context(() =>
                {
                    wordFoundAnimation = new WordFoundAnimation(new Word(new Square[] { }));
                    gameTime = new GameTime { ElapsedGameTime = TimeSpan.FromMilliseconds(GameConstants.Animation.WORD_FOUND_LIGHT_UP_TIME_MILLISECONDS - 1) };
                });

            "When I call animate".Do(() => wordFoundAnimation.Animate(gameTime));

            "Then the animation should not have finished".Observation(
                () => wordFoundAnimation.Finished().ShouldBeFalse());

        }

        [Specification]
        public void WordFoundAnimationFinishesWhenItsBeenRunningLongerThanConstantValue()
        {
            var wordFoundAnimation = default(WordFoundAnimation);
            var gameTime = default(GameTime);

            "Given less game time than the animation time has elapsed".Context(() =>
            {
                wordFoundAnimation = new WordFoundAnimation(new Word(new Square[] { }));
                gameTime = new GameTime { ElapsedGameTime = TimeSpan.FromMilliseconds(GameConstants.Animation.WORD_FOUND_LIGHT_UP_TIME_MILLISECONDS + 1) };
            });

            "When I call animate".Do(() => wordFoundAnimation.Animate(gameTime));

            "Then the animation should have finished".Observation(
                () => wordFoundAnimation.Finished().ShouldBeTrue());
        }


    }
}