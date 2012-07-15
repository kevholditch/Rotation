using Rotation.GameObjects.StandardBoard;

namespace Rotation.Drawing.Textures
{
    public class SquareDepthCalculator : ISquareDepthCalculator
    {
        public float Calculate(Square square)
        {
            return square.Angle == 0 ? 0.2f : 0.1f;
        }
    }
}