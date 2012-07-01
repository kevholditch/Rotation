using Rotation.GameObjects.Constants;

namespace Rotation.GameObjects.Drawing.ItemAnimators
{
    public class RotationAnimator : AnimatorBase<IRotationAnimationItem>
    {

        protected override void AnimateImp(IRotationAnimationItem animatableItem)
        {
            if (animatableItem.Direction == RotationDirection.None)
                return;

            if (animatableItem.Direction == RotationDirection.Clockwise)
            {
                animatableItem.Angle = animatableItem.Angle + GameConstants.Animation.ANGLE_INCREASE_RATE;

                if (animatableItem.Angle > 0)
                {
                    animatableItem.Angle = 0;
                    animatableItem.Direction = RotationDirection.None;
                }
            }

            if (animatableItem.Direction == RotationDirection.AntiClockwise)
            {
                animatableItem.Angle = animatableItem.Angle - GameConstants.Animation.ANGLE_INCREASE_RATE;

                if (animatableItem.Angle < 0)
                {
                    animatableItem.Angle = 0;
                    animatableItem.Direction = RotationDirection.None;
                }
            }

            
        }
    }
}