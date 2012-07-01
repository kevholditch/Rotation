using Rotation.GameObjects.Drawing;

namespace Rotation.Drawing.ItemAnimators
{
    public interface IItemAnimator
    {
        bool CanAnimate(IAnimatableItem animatableItem);
        void Animate(IAnimatableItem animatableItem);
    }
}
