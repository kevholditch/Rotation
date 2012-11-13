using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace Rotation.Drawing.Animations
{
    public class AnimationEngine : IAnimationEngine
    {
        private readonly IAnimationStore _animationStore;

        public AnimationEngine(IAnimationStore animationStore)
        {
            _animationStore = animationStore;
        }

        public void Run(GameTime gameTime)
        {
            var finishedAnimations = new List<IAnimation>();

            foreach (var animation in _animationStore.GetCurrentAnimations())
            {
                animation.Animate(gameTime);

                if (animation.Finished())
                    finishedAnimations.Add(animation);
            }

            foreach (var finishedAnimation in finishedAnimations)
            {
                _animationStore.Remove(finishedAnimation);
            }
            
        }
    }
}