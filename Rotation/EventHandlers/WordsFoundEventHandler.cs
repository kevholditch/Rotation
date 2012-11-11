using Rotation.Drawing.Animations;
using Rotation.Events;

namespace Rotation.EventHandlers
{
    public class WordsFoundEventHandler : IGameEventHandler<WordsFoundEvent>
    {
        private readonly IAnimationStore _animationStore;

        public WordsFoundEventHandler(IAnimationStore animationStore)
        {
            _animationStore = animationStore;
        }

        public void Handle(WordsFoundEvent gameEvent)
        {
            foreach (var word in gameEvent.Words)
            {
                _animationStore.Add(new WordFoundAnimation(word));
            }
        }
    }
}
