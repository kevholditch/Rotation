using System.Collections.Generic;
using Rotation.GameObjects.Drawing;

namespace Rotation.GameObjects.StandardBoard
{
    public interface IBoard : IGetAnimatableItems, IGetMainSelectedSquare
    {
        List<List<Square>> Rows { get; }
        List<List<Square>> Columns { get; }
        Square this[int x, int y] { get; }
    }
}