using System.Collections.Generic;
using Rotation.StandardBoard;

namespace Rotation.Blocks
{
    public class Block
    {

        public IEnumerable<BoardCoordinate> BoardCoordinates { get; private set; }

        public Block(IEnumerable<BoardCoordinate> boardCoordinates)
        {
            BoardCoordinates = boardCoordinates;
        }
    }
}