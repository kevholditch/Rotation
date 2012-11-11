using Microsoft.Xna.Framework.Graphics;
using Rotation.Drawing;

namespace Rotation.ItemDrawers
{
    public interface IItemDrawer
    {
        bool CanDraw(IAnimatableItem animatableItem);
        void Draw(SpriteBatch spriteBatch, IAnimatableItem animatableItem);
    }
}