using Rotation.Drawing.Animations;
using Rotation.Events;
using Rotation.StandardBoard;

namespace Rotation.EventHandlers
{
    public class BlocksFoundEventHandler : IGameEventHandler<BlocksFoundEvent>
    {
        private readonly IAnimationStore _animationStore;
        private readonly IBoard _board;

        public BlocksFoundEventHandler(IAnimationStore animationStore, IBoard board)
        {
            _animationStore = animationStore;
            _board = board;
        }

        public void Handle(BlocksFoundEvent gameEvent)
        {
            _animationStore.Add(new BlocksFoundAnimation(gameEvent.Blocks, _board));
        }
    }
}