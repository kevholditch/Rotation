using System.Collections.Generic;
using Rotation.Words;

namespace Rotation.Events
{
    public class WordsFoundEvent : IGameEvent
    {
        public IEnumerable<IWord> Words { get; set; } 
    }

    
}