using System.Collections.Generic;
using Rotation.Blocks;

namespace Rotation.GameControl
{
    public interface IScoreManager
    {
        IScore GetScore();
        void BlocksFound(IEnumerable<Block> blocksFound);
    }

}
