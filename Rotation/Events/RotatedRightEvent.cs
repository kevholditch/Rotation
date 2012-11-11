using System.Collections.Generic;
using Rotation.StandardBoard;

namespace Rotation.Events
{
    public class RotatedRightEvent : IGameEvent
    {
        public IEnumerable<BoardCoordinate> BoardCoordinates { get; set; } 
    }

    
}