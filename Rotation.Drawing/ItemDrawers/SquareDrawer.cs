using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Rotation.Drawing.Textures;
using Rotation.GameObjects.Drawing;
using Rotation.GameObjects.StandardBoard;

namespace Rotation.Drawing.ItemDrawers
{
    public class SquareDrawer : ItemDrawerBase<Square>
    {
        
        protected override void DrawImp(SpriteBatch spriteBatch, ITextureLoader textureLoader, Square square)
        {
            Texture2D texture = null;

            if (square.IsSelectable)
            {
                if (square.HasTile)
                {
                    texture = textureLoader.Load(string.Format("{0}{1}", DrawingConstants.STANDARD_TILE, square.Letter.Value.ToString()));

                }else
                {
                    texture = textureLoader.Load(DrawingConstants.BLANK_TILE);
                }
   
            }else
            {
                texture = textureLoader.Load(DrawingConstants.NON_TILE);
            }
            
            
            var xPos = (square.XPos*40) + 10;
            var yPos = (square.YPos*40) + 10;
            spriteBatch.Draw(texture, new Vector2(xPos, yPos));
        }
    }
}