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

        	var blocksToAnimate = new List<BoardCoordinate>();

            foreach (var column in columnGroupings.OrderBy(c => c.Key))
            {
                blocksToAnimate.AddRange(SetOffsets(column, _board));
            }

			_animationStore.Add(new BlocksFallingAnimation(blocksToAnimate));        	
        }

        private List<BoardCoordinate> SetOffsets(IEnumerable<BoardCoordinate> column, IBoard board)
        {
            var squaresInColumn = column.OrderBy(c => c.Y).ToList();

			var stack = new Stack<int>(Enumerable.Range(0, squaresInColumn[squaresInColumn.Count - 1].Y)
									.Where(i => !squaresInColumn.Select(s => s.Y).Contains(i)));

        	var result = new List<BoardCoordinate>();

			int currentOffset = 0;
			if (stack.Count == 0)
			{
				currentOffset = squaresInColumn[squaresInColumn.Count - 1].Y;
			}
			
        	for (int i = squaresInColumn[squaresInColumn.Count - 1].Y; i >= 0; i--)
			{			
				if (stack.Count > 0)
				{					
					currentOffset = i - stack.Pop();
				}

				board[squaresInColumn.First().X, i].YOffset = currentOffset * DrawingConstants.Tiles.TILE_HEIGHT;

				result.Add(new BoardCoordinate(squaresInColumn.First().X, i));
			}

        	return result;
        }
    }
}
