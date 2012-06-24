using Microsoft.Xna.Framework;
using Rotation.GameObjects.StandardBoard;

namespace Rotation.Drawing.Textures
{
    public interface ISquareColourSelector
    {
        Color SelectColour(Square square);
    }
}