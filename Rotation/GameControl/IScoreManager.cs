using System.Collections.Generic;
using Rotation.Blocks;

namespace Rotation.GameControl
{
    public interface IScoreManager
    {
        IScore GetScore();
        void FoundBlock(IEnumerable<Block> blocksFound);
    }

}
