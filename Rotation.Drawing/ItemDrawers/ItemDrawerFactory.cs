using System.Collections.Generic;
using System.Linq;
using Rotation.GameObjects.Drawing;

namespace Rotation.Drawing.ItemDrawers
{
    public class ItemDrawerFactory
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
