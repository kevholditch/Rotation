using System;
using Microsoft.Xna.Framework.Graphics;

namespace Rotation.Drawing.Textures
{
    public class XnaTextureLoader : ITextureLoader
    {
        private readonly Func<string, Texture2D> _loadFunc;

        public XnaTextureLoader(Func<string, Texture2D> loadFunc)
        {
            _loadFunc = loadFunc;
        }

        public Texture2D Load(string textureName)
        {
            return _loadFunc(textureName);
        }
    }
}