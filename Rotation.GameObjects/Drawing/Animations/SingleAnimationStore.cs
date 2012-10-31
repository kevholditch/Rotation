using System.Collections.Generic;

namespace Rotation.GameObjects.Drawing.Animations
{
    public class SingleAnimationStore : IAnimationStore
    {

        private readonly List<IAnimation> _animations;

        public SingleAnimationStore()
        {
            _animations = new List<IAnimation>();
        }

        public void Add(IAnimation animation)
        {
            _animations.Add(animation);
        }

        public IEnumerable<IAnimation> GetCurrentAnimations()
        {
            return _animations;
        }

        public void Remove(IAnimation animation)
        {
            animation.OnFinished();
            _animations.Remove(animation);
        }
    }
}