using Microsoft.Xna.Framework.Graphics;

namespace Rotation.Drawing.Textures
{
    public interface ITextureLoader
    {
        Texture2D Load(string textureName);
    }
}
