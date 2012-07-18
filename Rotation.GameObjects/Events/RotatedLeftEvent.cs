using System.Collections.Generic;
using Rotation.GameObjects.StandardBoard;

namespace Rotation.GameObjects.Events
{
    public class RotatedLeftEvent : IGameEvent
    {
        public IEnumerable<Square> Squares { get; set; }
    }
}