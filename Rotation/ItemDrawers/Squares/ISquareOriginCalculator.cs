using Microsoft.Xna.Framework;

namespace Rotation.ItemDrawers.Squares
{
    public interface ISquareOriginCalculator
    {
        Vector2 Calculate(int x, int y);
    }


}