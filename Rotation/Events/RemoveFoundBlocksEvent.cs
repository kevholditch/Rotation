using System.Collections.Generic;
using Rotation.StandardBoard;

namespace Rotation.Events
{
    public class RemoveFoundBlocksEvent : IGameEvent
    {
        public List<BoardCoordinate> SquaresInBlocks { get; private set; }
 
        public RemoveFoundBlocksEvent(List<BoardCoordinate> squaresInBlocks)
        {
            SquaresInBlocks = squaresInBlocks;
        }
    }

}
