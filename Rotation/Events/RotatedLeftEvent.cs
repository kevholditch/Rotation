using System.Collections.Generic;
using Rotation.StandardBoard;

namespace Rotation.Events
{
    public class RotatedLeftEvent : IGameEvent
    {
        public IEnumerable<BoardCoordinate> BoardCoordinates { get; set; }
    }
}