using Rotation.GameObjects.Drawing.Animations;
using Rotation.GameObjects.StandardBoard;

namespace Rotation.GameObjects.Events.EventHandlers
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