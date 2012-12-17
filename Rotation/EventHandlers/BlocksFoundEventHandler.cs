using Rotation.Drawing.Animations;
using Rotation.Events;

namespace Rotation.EventHandlers
{
    public class BlocksFoundEventHandler : IGameEventHandler<BlocksFoundEvent>
    {
        private IAnimationStore _animationStore;

        public BlocksFoundEventHandler(IAnimationStore animationStore)
        {
            _animationStore = animationStore;
        }

        public void Handle(BlocksFoundEvent gameEvent)
        {
            _animationStore.Add(new BlocksFoundAnimation(gameEvent.Blocks));
        }
    }
}