using Rotation.Drawing.Animations;
using Rotation.Events;
using Rotation.GameControl;
using Rotation.StandardBoard;

namespace Rotation.EventHandlers
{
    public class RotatedLeftEventHandler : IGameEventHandler<RotatedLeftEvent>
    {
        private readonly IAnimationStore _animationStore;
        private readonly IBoard _board;
        private readonly IGameManager _gameManager;

        public RotatedLeftEventHandler(IAnimationStore animationStore, IBoard board, IGameManager gameManager)
        {
            _animationStore = animationStore;
            _board = board;
            _gameManager = gameManager;
        }

        public void Handle(RotatedLeftEvent gameEvent)
        {
            _animationStore.Add(new RotateLeftAnimation(gameEvent.BoardCoordinates, _board));
            _gameManager.RotationMade();
        }
    }
}