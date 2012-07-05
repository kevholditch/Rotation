using System.Collections.Generic;
using Rotation.GameObjects.Drawing;

namespace Rotation.GameObjects.StandardBoard
{
    public interface IBoard : IGetAnimatableItems, IGetMainSelectedSquare
    {
        List<Line> Rows { get; }
        List<Line> Columns { get; }
        Square this[int x, int y] { get; }
    }
}