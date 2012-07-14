using System.Collections.Generic;
using Rotation.GameObjects.StandardBoard;

namespace Rotation.GameObjects.Words
{
    public interface IFoundWord
    {
        string Word { get; }
        int Score { get; }
        IEnumerable<ISquare> Squares{ get; }
    }
}