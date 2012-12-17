using Rotation.Drawing.Animations;
using Rotation.Events;
using Rotation.StandardBoard;

namespace Rotation.EventHandlers
{
    public class RotatedLeftEventHandler : IGameEventHandler<RotatedLeftEvent>
    {
        private readonly IAnimationStore _animationStore;
        private readonly IBoard _board;

        public RotatedLeftEventHandler(IAnimationStore animationStore, IBoard board)
        {
            _animationStore = animationStore;
            _board = board;
        }

        public void Handle(RotatedLeftEvent gameEvent)
        {
            _animationStore.Add(new RotateLeftAnimation(gameEvent.BoardCoordinates, _board));
        }
    }
}