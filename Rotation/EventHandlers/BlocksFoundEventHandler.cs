using Rotation.Drawing.Animations;
using Rotation.Events;
using Rotation.GameControl;
using Rotation.StandardBoard;

namespace Rotation.EventHandlers
{
    public class BlocksFoundEventHandler : IGameEventHandler<BlocksFoundEvent>
    {
        private readonly IAnimationStore _animationStore;
        private readonly IBoard _board;
        private readonly IGameManager _gameManager;
        

        public BlocksFoundEventHandler(IAnimationStore animationStore, IBoard board, IGameManager gameManager)
        {
            _animationStore = animationStore;
            _board = board;
            _gameManager = gameManager;
        }

        public void Handle(BlocksFoundEvent gameEvent)
        {
            _animationStore.Add(new BlocksFoundAnimation(gameEvent.Blocks, _board));
            _gameManager.BlockFound(gameEvent.Blocks);
        }
    }
}