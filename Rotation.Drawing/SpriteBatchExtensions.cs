using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Rotation.Drawing
{
    public static class SpriteBatchExtensions
    {
        public static void Draw(this SpriteBatch spriteBatch, Texture2D texture2D, Vector2 position)
        {
            spriteBatch.Draw(texture2D, position, Color.White);
        }
    }
}
