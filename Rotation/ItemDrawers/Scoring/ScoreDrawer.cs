using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Rotation.GameControl;
using Rotation.Textures;

namespace Rotation.ItemDrawers.Scoring
{
    public class ScoreDrawer : ItemDrawerBase<Score>
    {
        private readonly ITextureLoader _textureLoader;

        public ScoreDrawer(ITextureLoader textureLoader)
        {
            _textureLoader = textureLoader;
        }

        protected override void DrawImp(SpriteBatch spriteBatch, Score drawableItem)
        {

            spriteBatch.DrawString(_textureLoader.LoadFont(), string.Format("Score: {0}", drawableItem.CurrentScore),
                                   new Vector2(10, 370), Color.Black);

            spriteBatch.DrawString(_textureLoader.LoadFont(), string.Format("Squares made: {0}", drawableItem.TotalSquaresMade),
                                   new Vector2(10, 390), Color.Black);

        }
    }

}
