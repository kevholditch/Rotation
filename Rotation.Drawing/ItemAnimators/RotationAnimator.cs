using Rotation.GameObjects.Drawing;

namespace Rotation.Drawing.ItemAnimators
{
    public class RotationAnimator : AnimatorBase<IRotationAnimationItem>
    {

        protected override void AnimateImp(int frame, IRotationAnimationItem animatableItem)
        {
            if (animatableItem.Direction == RotationDirection.None)
                return;

            if (animatableItem.Direction == RotationDirection.Clockwise)
            {
                animatableItem.Angle++;
            }

            if (animatableItem.Direction == RotationDirection.AntiClockwise)
            {
                animatableItem.Angle--;
            }

            if (animatableItem.Angle == 0)
            {
                animatableItem.Direction = RotationDirection.None;
            }
        }
    }
}