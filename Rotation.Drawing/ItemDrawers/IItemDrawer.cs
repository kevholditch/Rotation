using Microsoft.Xna.Framework.Graphics;
using Rotation.GameObjects.Drawing;

namespace Rotation.Drawing.ItemDrawers
{
    public interface IItemDrawer
    {
        bool CanDraw(IAnimatableItem animatableItem);
        void Draw(SpriteBatch spriteBatch, IAnimatableItem animatableItem);
    }
}