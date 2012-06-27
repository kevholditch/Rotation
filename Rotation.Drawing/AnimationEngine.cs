using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Rotation.Drawing.ItemAnimators;
using Rotation.Drawing.ItemDrawers;
using Rotation.GameObjects.Drawing;

namespace Rotation.Drawing
{
    public class AnimationEngine
    {


        private IItemAnimatorFactory _itemAnimatorFactory;
        private IItemDrawerFactory _itemDrawerFactory;
        private Func<IEnumerable<IAnimatableItem>> _getAnimatablesFunc;
        private int _frame;

        public AnimationEngine(IItemAnimatorFactory itemAnimatorFactory, IItemDrawerFactory itemDrawerFactory, Func<IEnumerable<IAnimatableItem>> getAnimatablesFunc)
        {
            _itemAnimatorFactory = itemAnimatorFactory;
            _itemDrawerFactory = itemDrawerFactory;
            _getAnimatablesFunc = getAnimatablesFunc;
            _frame = 0;
        }


        public void Animate(SpriteBatch spriteBatch)
        {

            foreach (var animatableItem in _getAnimatablesFunc())
            {
                foreach (var itemAnimator in _itemAnimatorFactory.Create(animatableItem))
                {
                    itemAnimator.Animate(_frame, animatableItem);
                }

                var itemDrawer = _itemDrawerFactory.Create(animatableItem);
                itemDrawer.Draw(spriteBatch, animatableItem);
            }

            _frame++;
            if (_frame > 59)
                _frame = 0;

        }
    }
}
