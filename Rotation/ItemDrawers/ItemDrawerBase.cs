using Microsoft.Xna.Framework.Graphics;
using Rotation.Drawing;

namespace Rotation.ItemDrawers
{
    public abstract class ItemDrawerBase<T> : IItemDrawer where T : class, IAnimatableItem 
    {
        public bool CanDraw(IAnimatableItem animatableItem)
        {
            return animatableItem is T;
        }

        public void Draw(SpriteBatch spriteBatch, IAnimatableItem animatableItem)
        {
            DrawImp(spriteBatch, animatableItem as T);
        }

        protected abstract void DrawImp(SpriteBatch spriteBatch, T drawableItem);

        
    }
}
