using System.Collections.Generic;
using Rotation.Drawing;

namespace Rotation.StandardBoard
{
    public interface IBoard : IGetDrawableItems, IGetMainSelectedSquare
    {
        List<List<Square>> Rows { get; }
        List<List<Square>> Columns { get; }
        Square this[int x, int y] { get; }
        BoardCoordinate CentreSquare { get; }
    }
}