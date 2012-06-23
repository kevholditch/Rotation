using Rotation.GameObjects.Drawing;

namespace Rotation.Drawing.ItemDrawers
{
    public abstract class ItemDrawerBase<T> : IItemDrawer where T : IDrawableItem
    {
        public bool CanDraw(IDrawableItem drawableItem)
        {
            return drawableItem is T;
        }

        public abstract void Draw(IDrawableItem drawableItem);
    }
}
