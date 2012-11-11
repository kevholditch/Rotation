using Rotation.Words;

namespace Rotation.Drawing.Animations
{
    public class WordFoundAnimation : IAnimation
    {
 
        private int _frame;
        private readonly IWord _word;

        public WordFoundAnimation(IWord word)
        {
            _frame = 60;
            _word = word;

            foreach (var square in _word.Squres)
                square.InWord = true;      
        }

        public bool Finished()
        {
            return _frame <= 0;
        }

        public void Animate()
        {
            _frame--;
        }

        public void OnFinished()
        {
            foreach (var square in _word.Squres)
                square.InWord = false;
        }
    }
}
