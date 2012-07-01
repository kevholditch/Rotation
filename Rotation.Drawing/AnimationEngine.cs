using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;
using Rotation.Drawing.ItemDrawers;
using Rotation.GameObjects.Drawing;
using Rotation.GameObjects.Drawing.ItemAnimators;

namespace Rotation.Drawing
{
    public class AnimationEngine
    {
        private readonly IItemAnimatorFactory _itemAnimatorFactory;
        private readonly IItemDrawerFactory _itemDrawerFactory;
        private readonly Func<IEnumerable<IAnimatableItem>> _getAnimatables;

        public AnimationEngine(IItemAnimatorFactory itemAnimatorFactory, IItemDrawerFactory itemDrawerFactory, Func<IEnumerable<IAnimatableItem>> getAnimatables)
        {
            _itemAnimatorFactory = itemAnimatorFactory;
            _itemDrawerFactory = itemDrawerFactory;
            _getAnimatables = getAnimatables;
        }


        public void Animate(SpriteBatch spriteBatch)
        {

            foreach (var animatableItem in _getAnimatables())
            {
                foreach (var itemAnimator in _itemAnimatorFactory.Create(animatableItem))
                {
                    itemAnimator.Animate(animatableItem);
                }

                var itemDrawer = _itemDrawerFactory.Create(animatableItem);
                itemDrawer.Draw(spriteBatch, animatableItem);
            }
        }
    }
}
