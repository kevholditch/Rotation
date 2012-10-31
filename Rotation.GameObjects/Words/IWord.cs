using System.Collections.Generic;
using Rotation.GameObjects.StandardBoard;

namespace Rotation.GameObjects.Words
{
    public interface IWord
    {
        string Value { get; }
        int Score { get; }
        IEnumerable<Square> Squres { get; } 
    }
}