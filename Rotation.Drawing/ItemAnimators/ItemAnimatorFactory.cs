using System.Collections.Generic;
using System.Linq;
using Rotation.GameObjects.Drawing;

namespace Rotation.Drawing.ItemAnimators
{
    public class ItemAnimatorFactory : IItemAnimatorFactory
    {

        private IEnumerable<IItemAnimator> _itemAnimators;

        public ItemAnimatorFactory(IEnumerable<IItemAnimator> itemAnimators)
        {
            _itemAnimators = itemAnimators;
        }

        public IEnumerable<IItemAnimator> Create(IAnimatableItem animatableItem)
        {
            return _itemAnimators.Where(i => i.CanAnimate(animatableItem));
        }
    }
}