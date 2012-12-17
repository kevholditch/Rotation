using System.Collections.Generic;
using Rotation.Blocks;

namespace Rotation.Events
{
    public class BlocksFoundEvent : IGameEvent
    {
        public IEnumerable<Block> Blocks { get; private set;}
 
        public BlocksFoundEvent(IEnumerable<Block> blocks)
        {
            Blocks = blocks;
        }
    }
}