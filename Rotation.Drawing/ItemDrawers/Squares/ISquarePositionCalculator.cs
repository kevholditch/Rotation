using Microsoft.Xna.Framework;
using Rotation.GameObjects.StandardBoard;

namespace Rotation.Drawing.ItemDrawers.Squares
{
    public interface ISquarePositionCalculator
    {
        Vector2 Calculate();
    }
}