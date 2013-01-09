using System.Collections.Generic;
using Rotation.Blocks;

namespace Rotation.GameControl
{
    public interface IRotationManager
    {
        void RotationMade();
        void BlocksFound(IEnumerable<Block> blocks);
        IRotationInformation GetRotationInformation();
    }
}