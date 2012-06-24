using System.Collections.Generic;

namespace Rotation.GameObjects.Drawing
{
    public interface IGetDrawableItems
    {
        IEnumerable<IDrawableItem> GetDrawables();
    }
}