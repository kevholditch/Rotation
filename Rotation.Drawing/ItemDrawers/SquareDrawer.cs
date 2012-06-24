using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Rotation.GameObjects.StandardBoard;

namespace Rotation.Drawing.ItemDrawers
{
    public class SquareDrawer : ItemDrawerBase<Square>
    {
        private readonly ITileTextureFactory _tileTextureFactory;

        public SquareDrawer(ITileTextureFactory tileTextureFactory)
        {
            _tileTextureFactory = tileTextureFactory;
        }

        protected override void DrawImp(SpriteBatch spriteBatch, Square square)
        {
            var textureFactory = _tileTextureFactory.Create(square.Tile);
            var texture = textureFactory.Create(square.Tile);
            
            var xPos = (square.XPos*texture.Width) + 10;
            var yPos = (square.YPos*texture.Width) + 10;

            spriteBatch.Draw(texture, new Vector2(xPos, yPos));
        }
    }
}