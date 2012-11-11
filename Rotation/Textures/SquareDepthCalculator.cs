using Rotation.StandardBoard;

namespace Rotation.Textures
{
    public class SquareDepthCalculator : ISquareDepthCalculator
    {
        public float Calculate(Square square)
        {
            return square.Angle == 0 ? 0.2f : 0.1f;
        }
    }
}