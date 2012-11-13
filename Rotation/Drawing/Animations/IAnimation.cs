using Microsoft.Xna.Framework;

namespace Rotation.Drawing.Animations
{
    public interface IAnimation
    {
        bool Finished();
        void Animate(GameTime gameTime);
        void OnFinished();
    }
}
