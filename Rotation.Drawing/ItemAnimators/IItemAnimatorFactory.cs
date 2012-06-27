using System.Collections.Generic;
using Rotation.GameObjects.Drawing;

namespace Rotation.Drawing.ItemAnimators
{
    public interface IItemAnimatorFactory
    {
        IEnumerable<IItemAnimator> Create(IAnimatableItem animatableItem);
    }
}
