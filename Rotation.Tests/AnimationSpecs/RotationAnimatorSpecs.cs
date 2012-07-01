using FakeItEasy;
using Rotation.GameObjects.Constants;
using Rotation.GameObjects.Drawing;
using Rotation.GameObjects.Drawing.ItemAnimators;
using SubSpec;
using Rotation.Tests.Common;

namespace Rotation.GameObjects.sTests.AnimationSpecs
{
    public class RotationAnimatorSpecs
    {
        [Specification]
        public void CanCorrectlyIncrementAngleForClockwiseRotation()
        {
            var rotationAnimator = default(RotationAnimator);
            var rotationAnimationItem = default(IRotationAnimationItem);

            "Given that I have a rotation animator and an animatable item that should be rotating clockwise with an angle of -90".Context(
                () =>
                    {
                        rotationAnimator = new RotationAnimator();
                        rotationAnimationItem = A.Fake<IRotationAnimationItem>();
                        rotationAnimationItem.Angle = -90;
                        rotationAnimationItem.Direction = RotationDirection.Clockwise;
                        
                    });

            "When I call animate".Do(() => rotationAnimator.Animate(rotationAnimationItem));

            "Then the angle should increase by the animation constant".Observation(
                () =>
                rotationAnimationItem.Angle.ShouldEqual(-90 + GameConstants.Animation.ANGLE_INCREASE_RATE));

            "Then the direction should still be clockwise".Observation(
                () => rotationAnimationItem.Direction.ShouldEqual(RotationDirection.Clockwise));

        }

        [Specification]
        public void CanCorrectlyIncrementAngleForAntiClockwiseRotation()
        {
            var rotationAnimator = default(RotationAnimator);
            var rotationAnimationItem = default(IRotationAnimationItem);

            "Given that I have a rotation animator and an animatable item that should be rotating clockwise with an angle of 90".Context(
                () =>
                {
                    rotationAnimator = new RotationAnimator();
                    rotationAnimationItem = A.Fake<IRotationAnimationItem>();
                    rotationAnimationItem.Angle = 90;
                    rotationAnimationItem.Direction = RotationDirection.AntiClockwise;

                });

            "When I call animate".Do(() => rotationAnimator.Animate(rotationAnimationItem));

            "Then the angle should decrease by the animation constant".Observation(
                () =>
                rotationAnimationItem.Angle.ShouldEqual(90 - GameConstants.Animation.ANGLE_INCREASE_RATE));

            "Then the direction should still be anti-clockwise".Observation(
                () => rotationAnimationItem.Direction.ShouldEqual(RotationDirection.AntiClockwise));

        }

        [Specification]
        public void CanCorrectlyFinishClockwiseAnimation()
        {
            var rotationAnimator = default(RotationAnimator);
            var rotationAnimationItem = default(IRotationAnimationItem);

            "Given that I have a clockwise rotation animation item that has one frame to go".Context(
                () =>
                {
                    rotationAnimator = new RotationAnimator();
                    rotationAnimationItem = A.Fake<IRotationAnimationItem>();
                    rotationAnimationItem.Angle = -1;
                    rotationAnimationItem.Direction = RotationDirection.Clockwise;

                });

            "When I call animate".Do(() => rotationAnimator.Animate(rotationAnimationItem));

            "Then the angle should increase be set to 0".Observation(
                () =>
                rotationAnimationItem.Angle.ShouldEqual(0));

            "Then the direction should still be none".Observation(
                () => rotationAnimationItem.Direction.ShouldEqual(RotationDirection.None));

        }

        [Specification]
        public void CanCorrectlyFinishAntiClockwiseAnimation()
        {
            var rotationAnimator = default(RotationAnimator);
            var rotationAnimationItem = default(IRotationAnimationItem);

            "Given that I have a anti-clockwise rotation animation item that has one frame to go".Context(
                () =>
                {
                    rotationAnimator = new RotationAnimator();
                    rotationAnimationItem = A.Fake<IRotationAnimationItem>();
                    rotationAnimationItem.Angle = 1;
                    rotationAnimationItem.Direction = RotationDirection.AntiClockwise;

                });

            "When I call animate".Do(() => rotationAnimator.Animate(rotationAnimationItem));

            "Then the angle should increase be set to 0".Observation(
                () =>
                rotationAnimationItem.Angle.ShouldEqual(0));

            "Then the direction should still be none".Observation(
                () => rotationAnimationItem.Direction.ShouldEqual(RotationDirection.None));

        }

    }
}
