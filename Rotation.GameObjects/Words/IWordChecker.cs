using System.Collections.Generic;
using Rotation.GameObjects.StandardBoard;

namespace Rotation.GameObjects.Words
{
    public interface IWordChecker
    {
        IEnumerable<IWord> Check(IEnumerable<IEnumerable<Square>> squares);
    }
}