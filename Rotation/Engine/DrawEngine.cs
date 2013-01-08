using Microsoft.Xna.Framework.Graphics;
using System.Linq;
using Rotation.Drawing;
using Rotation.ItemDrawers;

namespace Rotation.Engine
{
    public class DrawEngine : IDrawEngine
    {
        private readonly IItemDrawerFactory _itemDrawerFactory;
        private readonly IGetDrawableItems _getDrawables;

        public DrawEngine(IItemDrawerFactory itemDrawerFactory, IGetDrawableItems getDrawables)
        {
            _itemDrawerFactory = itemDrawerFactory;
            _getDrawables = getDrawables;
        }


        public void Draw(SpriteBatch spriteBatch)
        {

            foreach (var drawableItemTypes in _getDrawables.GetDrawables().GroupBy(t => t.GetType()))
            {
                var itemDrawer = _itemDrawerFactory.Create(drawableItemTypes.First());

                foreach (var drawableItem in drawableItemTypes)
                { 
                    itemDrawer.Draw(spriteBatch, drawableItem);
                }
               
            }
        }
    }
}
