using System.Collections.Generic;

namespace Rotation.Drawing
{
    public interface IGetAnimatableItems
    {
        IEnumerable<IAnimatableItem> GetAnimatables();
    }
}