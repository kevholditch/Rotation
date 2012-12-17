using Rotation.Drawing.Animations;
using Rotation.Events;
using Rotation.StandardBoard;

namespace Rotation.EventHandlers
{
    public class RotatedRightEventHandler : IGameEventHandler<RotatedRightEvent>
    {
        private readonly IAnimationStore _animationStore;
        private readonly IBoard _board;

        public RotatedRightEventHandler(IAnimationStore animationStore, IBoard board)
        {
            _animationStore = animationStore;
            _board = board;
        }

        public void Handle(RotatedRightEvent gameEvent)
        {
            _animationStore.Add(new RotateRightAnimation(gameEvent.BoardCoordinates, _board));
        }
    }
}