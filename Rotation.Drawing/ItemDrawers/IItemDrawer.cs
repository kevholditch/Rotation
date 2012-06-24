using Microsoft.Xna.Framework.Graphics;
using Rotation.GameObjects.Drawing;

namespace Rotation.Drawing.ItemDrawers
{
    public interface IItemDrawer
    {
        bool CanDraw(IDrawableItem drawableItem);
        void Draw(SpriteBatch spriteBatch, IDrawableItem drawableItem);
    }
}