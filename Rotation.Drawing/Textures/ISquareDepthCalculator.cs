using Rotation.GameObjects.StandardBoard;

namespace Rotation.Drawing.Textures
{
    public interface ISquareDepthCalculator
    {
        float Calculate(Square square);
    }
}