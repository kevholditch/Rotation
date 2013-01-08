using System.Collections.Generic;

namespace Rotation.Drawing
{
    public interface IGetDrawableItems
    {
        IEnumerable<IDrawableItem> GetDrawables();
    }
}