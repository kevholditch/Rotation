namespace Rotation.GameObjects.Drawing
{
    public interface IRotationAnimationItem : IAnimatableItem
    {
        int Angle { get; set; }
        RotationDirection Direction { get; set; }
    }
}