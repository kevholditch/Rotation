using Microsoft.Xna.Framework.Graphics;
using System.Linq;
using Rotation.Drawing;
using Rotation.ItemDrawers;

namespace Rotation.Engine
{
    public class DrawEngine : IDrawEngine
    {
        private readonly IItemDrawerFactory _itemDrawerFactory;
        private readonly IGetAnimatableItems _getAnimatables;

        public DrawEngine(IItemDrawerFactory itemDrawerFactory, IGetAnimatableItems getAnimatables)
        {
            _itemDrawerFactory = itemDrawerFactory;
            _getAnimatables = getAnimatables;
        }


        public void Animate(SpriteBatch spriteBatch)
        {

            foreach (var animatableItemTypes in _getAnimatables.GetAnimatables().GroupBy(t => t.GetType()))
            {
                var itemDrawer = _itemDrawerFactory.Create(animatableItemTypes.First());

                foreach (var animatableItem in animatableItemTypes)
                { 
                    itemDrawer.Draw(spriteBatch, animatableItem);
                }
               
            }
        }
    }
}
