using System.Collections.Generic;
using System.Linq;
using Rotation.Drawing;

namespace Rotation.ItemDrawers
{
    public class ItemDrawerFactory : IItemDrawerFactory
    {
        private readonly IEnumerable<IItemDrawer> _itemDrawers;

        public ItemDrawerFactory(IEnumerable<IItemDrawer> itemDrawers)
        {
            _itemDrawers = itemDrawers;
        }

        public IItemDrawer Create(IDrawableItem drawableItem)
        {
            return _itemDrawers.First(i => i.CanDraw(drawableItem));
        }
    }
}
