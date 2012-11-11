using Rotation.StandardBoard;

namespace Rotation.Textures
{
    public interface ISquareDepthCalculator
    {
        float Calculate(Square square);
    }
}