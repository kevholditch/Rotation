using Rotation.Events;
using Rotation.StandardBoard;

namespace Rotation.EventHandlers
{
    public class RemoveFoundBlocksEventHandler : IGameEventHandler<RemoveFoundBlocksEvent>
    {

        private IBoard _board;

        public RemoveFoundBlocksEventHandler(IBoard board)
        {
            _board = board;
        }

        public void Handle(RemoveFoundBlocksEvent gameEvent)
        {
               
        }
    }
}
