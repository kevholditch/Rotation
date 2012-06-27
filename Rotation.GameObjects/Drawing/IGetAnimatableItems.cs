using System.Collections.Generic;

namespace Rotation.GameObjects.Drawing
{
    public interface IGetAnimatableItems
    {
        IEnumerable<IAnimatableItem> GetAnimatables();
    }
}