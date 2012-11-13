using Microsoft.Xna.Framework;
using Rotation.Constants;
using Rotation.Words;

namespace Rotation.Drawing.Animations
{
    public class WordFoundAnimation : IAnimation
    {

        private double _elapsedTime;
        private readonly IWord _word;

        public WordFoundAnimation(IWord word)
        {
            _elapsedTime = 0;
            _word = word;

            foreach (var square in _word.Squres)
                square.InWord = true;      
        }

        public bool Finished()
        {
            return _elapsedTime > GameConstants.Animation.WORD_FOUND_LIGHT_UP_TIME_MILLISECONDS;
        }

        public void Animate(GameTime gameTime)
        {
            _elapsedTime += gameTime.ElapsedGameTime.TotalMilliseconds;
        }

        public void OnFinished()
        {
            foreach (var square in _word.Squres)
                square.InWord = false;
        }
    }
}
