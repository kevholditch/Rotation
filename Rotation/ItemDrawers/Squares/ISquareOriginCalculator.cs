using Microsoft.Xna.Framework;
using Rotation.StandardBoard;

namespace Rotation.ItemDrawers.Squares
{
    public interface ISquareOriginCalculator
    {
        Vector2 Calculate(Square square);
    }


}