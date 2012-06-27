using Rotation.GameObjects.Drawing;

namespace Rotation.Drawing.ItemDrawers
{
    public interface IItemDrawerFactory
    {
        IItemDrawer Create(IAnimatableItem animatableItem);
    }
}