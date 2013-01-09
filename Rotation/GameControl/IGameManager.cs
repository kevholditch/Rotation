using System.Collections.Generic;
using Rotation.Blocks;

namespace Rotation.GameControl
{
    public interface IGameManager
    {
        void RotationMade();
        void BlockFound(IEnumerable<Block> blocks);
    }
}