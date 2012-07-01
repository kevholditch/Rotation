using System.Collections.Generic;
using System.Linq;

namespace Rotation.GameObjects.Drawing.ItemAnimators
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