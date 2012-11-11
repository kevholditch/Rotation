using Rotation.Drawing;

namespace Rotation.ItemDrawers
{
    public interface IItemDrawerFactory
    {
        IItemDrawer Create(IAnimatableItem animatableItem);
    }
}