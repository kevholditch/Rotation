using Microsoft.Xna.Framework;
using Rotation.StandardBoard;

namespace Rotation.ItemDrawers.Squares
{
    public interface ISquarePositionCalculator
    {
        Vector2 Calculate();
    }
}