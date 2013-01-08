using Rotation.Drawing;

namespace Rotation.GameControl
{
    public interface ILevel : IDrawableItem
    {
        int CurrentLevel { get; set; }
        int SquaresToNextLevel { get; set; }
    }
}