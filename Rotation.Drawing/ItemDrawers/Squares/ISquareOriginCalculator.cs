using Microsoft.Xna.Framework;

namespace Rotation.Drawing.ItemDrawers.Squares
{
    public interface ISquareOriginCalculator
    {
        Vector2 Calculate(int x, int y);
    }
}