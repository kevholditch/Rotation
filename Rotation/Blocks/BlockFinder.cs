using System.Collections.Generic;
using Rotation.StandardBoard;
using System.Linq;

namespace Rotation.Blocks
{
    public class BlockFinder : IBlockFinder
    {
        private const int BLOCK_SIZE = 2;

        public IEnumerable<Block> Find(IBoard board)
        {
            var blocks = new List<Block>();

            for (int i = 0; i < board.Columns.Count - (BLOCK_SIZE - 1); i++)
            {
                for (int j = 0; j < board.Rows.Count - (BLOCK_SIZE - 1); j++)
                {
                    var squares = GetSquares(board, i, j);
                    if (IsBlock(squares))
                    {
                        blocks.Add(new Block(squares));
                    }
                }
            }

            return blocks;
        }

        private IEnumerable<Square> GetSquares(IBoard board, int x, int y)
        {
            for (int i = x; i < x + BLOCK_SIZE; i++)
            {
                for (int j = y; j < y + BLOCK_SIZE; j++)
                {
                    yield return board[i, j];
                }
            }
        }

        private bool IsBlock(IEnumerable<Square> squares)
        {
            var squareList = squares.ToList();


            for (int i = 0; i < squareList.Count - 1; i++)
            {
                
                if (squareList[i].HasTile == false ||
                    squareList[i+1].HasTile == false ||
                    squareList[i].Colour != squareList[i + 1].Colour)
                    return false;
            }

            return true;

        }

    }
}
