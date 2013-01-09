using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Rotation.GameControl;
using Rotation.Textures;

namespace Rotation.ItemDrawers.Rotations
{
    public class RotationInformationDrawer : ItemDrawerBase<RotationInformation>
    {

        private readonly ITextureLoader _textureLoader;

        public RotationInformationDrawer(ITextureLoader textureLoader)
        {
            _textureLoader = textureLoader;
        }

        protected override void DrawImp(SpriteBatch spriteBatch, RotationInformation drawableItem)
        {
            spriteBatch.DrawString(_textureLoader.LoadFont(), string.Format("Rotations: {0}", drawableItem.RotationsLeft),
                                   new Vector2(200, 430), Color.Black);
        }
    }
}
