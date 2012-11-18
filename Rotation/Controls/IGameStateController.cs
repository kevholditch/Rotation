using Microsoft.Xna.Framework;

namespace Rotation.Controls
{
    public interface IGameStateController
    {
        void Initialise();
        void Update(GameTime gameTime);
    }
}