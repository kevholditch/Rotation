using System.Collections.Generic;
using Rotation.Blocks;

namespace Rotation.GameControl
{
    public interface IScoreManager
    {
        IScore GetProgress();
        void FoundBlock(IEnumerable<Block> blocksFound);
    }
}
