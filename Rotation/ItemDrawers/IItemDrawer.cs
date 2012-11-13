using Microsoft.Xna.Framework.Graphics;
using Rotation.Drawing;

namespace Rotation.ItemDrawers
{
    public interface IItemDrawer
    {
        bool CanDraw(IDrawableItem drawableItem);
        void Draw(SpriteBatch spriteBatch, IDrawableItem drawableItem);
    }
}