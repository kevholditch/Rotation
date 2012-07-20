using System.Collections.Generic;
using Rotation.GameObjects.Words;

namespace Rotation.GameObjects.Events
{
    public class WordsFoundEvent : IGameEvent
    {
        public IEnumerable<IWord> Words { get; set; } 
    }

    
}