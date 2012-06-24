using Microsoft.Xna.Framework.Graphics;
using Rotation.GameObjects.Drawing;

namespace Rotation.Drawing.ItemDrawers
{
    public abstract class ItemDrawerBase<T> : IItemDrawer where T : class, IDrawableItem 
    {
        public bool CanDraw(IDrawableItem drawableItem)
        {
            return drawableItem is T;
        }

        public void Draw(SpriteBatch spriteBatch, IDrawableItem drawableItem)
        {
            DrawImp(spriteBatch, drawableItem as T);
        }

        protected abstract void DrawImp(SpriteBatch spriteBatch, T drawableItem);

        
    }
}
