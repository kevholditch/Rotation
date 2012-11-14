using System;
using Microsoft.Xna.Framework;
using Rotation.Constants;
using Rotation.Drawing.Animations;
using Rotation.GameObjects.sTests.Builders;
using Rotation.StandardBoard;
using Rotation.Words;
using SubSpec;
using System.Linq;

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

        [Specification]
        public void WordFoundAnimationStartsBySettingEachSquareInTheWordToInWord()
        {
            var word = default(Word);

            "Given I have a word with 2 squares that are not in a word".Context(() =>
                word = new Word(new[]
                    { 
                        BuildA.Square(true, 0, 1).WithInWord(false).Build(),
                        BuildA.Square(true, 0, 2).WithInWord(false).Build()
                    }));

            "When I start the animation".Do(() => new WordFoundAnimation(word));

            "Then the first square should now have in word set to true".Observation(() =>
                word.Squres.ToArray()[0].InWord.ShouldBeTrue());

            "Then the second square should now have in word set to true".Observation(() =>
                word.Squres.ToArray()[1].InWord.ShouldBeTrue());

        }

        [Specification]
        public void WordFoundAnimationFinishesItSetsInWordToFalse()
        {
            var word = default(Word);
            var wordFoundAnimation = default(WordFoundAnimation);

            "Given I have a word with 2 squares that are in a word".Context(() =>
                {
                    word = new Word(new[]
                    { 
                        BuildA.Square(true, 0, 1).WithInWord(true).Build(),
                        BuildA.Square(true, 0, 2).WithInWord(true).Build()
                    });

                    wordFoundAnimation = new WordFoundAnimation(word);
                });

            "When I finish the animation".Do(() => wordFoundAnimation.OnFinished());

            "Then the first square should now have in word set to false".Observation(() =>
                word.Squres.ToArray()[0].InWord.ShouldBeFalse());

            "Then the second square should now have in word set to false".Observation(() =>
                word.Squres.ToArray()[1].InWord.ShouldBeFalse());

        }


    }
}