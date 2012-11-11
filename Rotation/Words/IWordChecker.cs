using System.Collections.Generic;
using Rotation.StandardBoard;

namespace Rotation.Words
{
    public interface IWordChecker
    {
        IEnumerable<IWord> Check(IEnumerable<IEnumerable<Square>> squares);
    }
}