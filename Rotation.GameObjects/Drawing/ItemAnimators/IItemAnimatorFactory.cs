using System.Collections.Generic;

namespace Rotation.GameObjects.Drawing.ItemAnimators
{
    public interface IItemAnimatorFactory
    {
        IEnumerable<IItemAnimator> Create(IAnimatableItem animatableItem);
    }
}
