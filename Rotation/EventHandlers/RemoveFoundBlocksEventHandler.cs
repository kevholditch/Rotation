using System.Collections.Generic;
using Rotation.Constants;
using Rotation.Drawing.Animations;
using Rotation.Engine;
using Rotation.Events;
using Rotation.StandardBoard;
using System.Linq;

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
            var columnGroupings = gameEvent.SquaresInBlocks.GroupBy(g => g.X);

            foreach (var column in columnGroupings.OrderBy(c => c.Key))
            {
                


            }
        }

        private void SetOffsets(IEnumerable<BoardCoordinate> column, IBoard board)
        {
            var squaresInColumn = column.OrderBy(c => c.Y).ToList();
            int currentIndex = 0;

            for (int i = 0; i <= squaresInColumn[squaresInColumn.Count - 1].Y; i++)
            {
                board[squaresInColumn[0].X, i].YOffset = (squaresInColumn.Count - currentIndex)*
                                                         DrawingConstants.Tiles.TILE_HEIGHT;


            }
        }
    }
}
