using Rotation.Events;
using Rotation.StandardBoard;

namespace Rotation.EventHandlers
{
    public class BoardChangedEventHandler : IGameEventHandler<BoardChangedEvent>
    {

        private readonly IBoard _board;

        public BoardChangedEventHandler(IBoard board)
        {
            _board = board;
        }

        public void Handle(BoardChangedEvent gameEvent)
        {
     
        }
    }
}