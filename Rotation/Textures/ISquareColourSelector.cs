using Microsoft.Xna.Framework;
using Rotation.StandardBoard;

namespace Rotation.Textures
{
    public interface ISquareColourSelector
    {
        Color SelectColour(Square square);
    }
}