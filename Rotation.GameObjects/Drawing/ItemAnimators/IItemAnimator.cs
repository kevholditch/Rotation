namespace Rotation.GameObjects.Drawing.ItemAnimators
{
    public interface IItemAnimator
    {
        bool CanAnimate(IAnimatableItem animatableItem);
        void Animate(IAnimatableItem animatableItem);
    }
}
