using System.Collections.Generic;

namespace Rotation.Drawing.Animations
{
    public interface IAnimationStore
    {
        void Add(IAnimation animation);
        IEnumerable<IAnimation> GetCurrentAnimations();
        void Remove(IAnimation animation);
    }
}