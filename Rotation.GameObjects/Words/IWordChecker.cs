using System.Collections.Generic;
using Rotation.GameObjects.StandardBoard;

namespace Rotation.GameObjects.Words
{
    public interface IWordChecker
    {
        IEnumerable<IFoundWord> Check(IEnumerable<IEnumerable<Square>> squares);
    }
}