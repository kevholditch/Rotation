using System.Collections.Generic;
using Rotation.StandardBoard;

namespace Rotation.Blocks
{
    public class Block
    {
        public IEnumerable<Square> Squares { get; private set; }
 
        public Block(IEnumerable<Square> squares)
        {
            Squares = squares;
        }
    }
}