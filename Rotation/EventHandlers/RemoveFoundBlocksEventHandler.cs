using Rotation.Drawing.Animations;
using Rotation.Events;
using Rotation.StandardBoard;

namespace Rotation.EventHandlers
{
    public class RemoveFoundBlocksEventHandler : IGameEventHandler<RemoveFoundBlocksEvent>
    {

        private IBoard _board;
        private IAnimationStore _animationStore;
        private IBoardFiller _boardFiller;

        public RemoveFoundBlocksEventHandler(IBoard board, IAnimationStore animationStore, IBoardFiller boardFiller)
        {
            _board = board;
            _animationStore = animationStore;
            _boardFiller = boardFiller;
        }

        public void Handle(RemoveFoundBlocksEvent gameEvent)
        {
               
        }
    }
}
