using Rotation.Drawing.Animations;
using Rotation.Events;
using Rotation.GameControl;
using Rotation.StandardBoard;

namespace Rotation.EventHandlers
{
    public class RotatedRightEventHandler : IGameEventHandler<RotatedRightEvent>
    {
        private readonly IAnimationStore _animationStore;
        private readonly IBoard _board;
        private readonly IGameManager _gameManager;

        public RotatedRightEventHandler(IAnimationStore animationStore, IBoard board, IGameManager gameManager)
        {
            _animationStore = animationStore;
            _board = board;
            _gameManager = gameManager;
        }

        public void Handle(RotatedRightEvent gameEvent)
        {
            _animationStore.Add(new RotateRightAnimation(gameEvent.BoardCoordinates, _board));
            _gameManager.RotationMade();
        }
    }
}