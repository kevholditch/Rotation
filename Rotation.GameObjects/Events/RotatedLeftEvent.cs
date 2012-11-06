using System.Collections.Generic;
using Rotation.GameObjects.StandardBoard;

namespace Rotation.GameObjects.Events
{
    public class RotatedLeftEvent : IGameEvent
    {
        public IEnumerable<BoardCoordinate> BoardCoordinates { get; set; }
    }
}