using Rotation.Drawing;

namespace Rotation.GameControl
{
    public interface IRotationInformation : IDrawableItem
    {
        int RotationsLeft { get; }
    }
}