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
        private readonly IScoreManager _scoreManager;
        private readonly ILevelManager _levelManager;

        public BlocksFoundEventHandler(IAnimationStore animationStore, IBoard board, IScoreManager scoreManager, ILevelManager levelManager)
        {
            _animationStore = animationStore;
            _board = board;
            _scoreManager = scoreManager;
            _levelManager = levelManager;
        }

        public void Handle(BlocksFoundEvent gameEvent)
        {
            _animationStore.Add(new BlocksFoundAnimation(gameEvent.Blocks, _board));
            _scoreManager.FoundBlock(gameEvent.Blocks);
            _levelManager.UpdateProgress(_scoreManager.GetScore());
        }
    }
}