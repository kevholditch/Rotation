using Microsoft.Xna.Framework.Graphics;

namespace Rotation.Textures
{
    public interface ITextureLoader
    {
        Texture2D Load(string textureName);
        SpriteFont LoadFont();
    }
}
