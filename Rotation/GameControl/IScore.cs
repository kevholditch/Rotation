using Rotation.Drawing;

namespace Rotation.GameControl
{
    public interface IScore : IDrawableItem
    {
        int CurrentScore { get; }
        int TotalSquaresMade { get; }
    }
}