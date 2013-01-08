using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Rotation.GameControl;
using Rotation.Textures;

namespace Rotation.ItemDrawers.Levels
{
    public class LevelDrawer : ItemDrawerBase<Level>
    {
        private readonly ITextureLoader _textureLoader;

        public LevelDrawer(ITextureLoader textureLoader)
        {
            _textureLoader = textureLoader;
        }

        protected override void DrawImp(SpriteBatch spriteBatch, Level drawableItem)
        {
            spriteBatch.DrawString(_textureLoader.LoadFont(), string.Format("Level: {0}", drawableItem.CurrentLevel),
                                   new Vector2(10, 410), Color.Black);

            spriteBatch.DrawString(_textureLoader.LoadFont(), string.Format("To level up: {0}", drawableItem.SquaresToNextLevel),
                                   new Vector2(10, 430), Color.Black);
        }
    }
}
