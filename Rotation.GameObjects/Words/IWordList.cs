using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rotation.GameObjects.Words
{
    public interface IWordList
    {
        IEnumerable<string> Words { get; } 
    }
}
