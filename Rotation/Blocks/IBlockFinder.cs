using System.Collections.Generic;
using Rotation.StandardBoard;

namespace Rotation.Blocks
{
    public interface IBlockFinder
    {
        IEnumerable<Block> Find(IBoard board);
    }
}