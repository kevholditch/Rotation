using System.Collections.Generic;
using Rotation.StandardBoard;

namespace Rotation.Words
{
    public interface IWord
    {
        string Value { get; }
        int Score { get; }
        IEnumerable<Square> Squres { get; } 
    }
}