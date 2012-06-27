using Rotation.GameObjects.Drawing;

namespace Rotation.Drawing.ItemAnimators
{
    public abstract class AnimatorBase<T> : IItemAnimator where T : class, IAnimatableItem 
    {
        public bool CanAnimate(IAnimatableItem animatableItem)
        {
            return animatableItem is T;
        }

        protected abstract void AnimateImp(int frame, T animatableItem);

        public void Animate(int frame, IAnimatableItem animatableItem)
        {
            AnimateImp(frame, animatableItem as T);
        }
    }
}