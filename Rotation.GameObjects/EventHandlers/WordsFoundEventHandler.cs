using System;
using Rotation.GameObjects.Drawing.Animations;
using Rotation.GameObjects.Events;

namespace Rotation.Drawing.EventHandlers
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
