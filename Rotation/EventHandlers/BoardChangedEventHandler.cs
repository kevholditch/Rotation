using System.Linq;
using Rotation.Blocks;
using Rotation.Events;
using Rotation.StandardBoard;

namespace Rotation.EventHandlers
{
    public class BoardChangedEventHandler : IGameEventHandler<BoardChangedEvent>
    {
        private readonly IBoard _board;
        private readonly IBlockFinder _blockFinder;

        public BoardChangedEventHandler(IBoard board, IBlockFinder blockFinder)
        {
            _board = board;
            _blockFinder = blockFinder;
        }

        public void Handle(BoardChangedEvent gameEvent)
        {
            var blocks = _blockFinder.Find(_board);

            if (blocks.Any())
            {
                GameEvents.Raise(new BlocksFoundEvent(blocks));
            }
        }
    }
}