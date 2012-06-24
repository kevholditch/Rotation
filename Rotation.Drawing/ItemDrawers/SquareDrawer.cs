using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Rotation.Drawing.Textures;
using Rotation.GameObjects.StandardBoard;

namespace Rotation.Drawing.ItemDrawers
{
    public class SquareDrawer : ItemDrawerBase<Square>
    {
        private readonly ITileTextureFactory _tileTextureFactory;
        private readonly ISquareColourSelector _squareColourSelector;

        public SquareDrawer(ITileTextureFactory tileTextureFactory, ISquareColourSelector squareColourSelector)
        {
            _tileTextureFactory = tileTextureFactory;
            _squareColourSelector = squareColourSelector;
        }

        protected override void DrawImp(SpriteBatch spriteBatch, Square square)
        {
            var tileTextureCreator = _tileTextureFactory.Create(square.Tile);
            var texture = tileTextureCreator.Create(square.Tile);
            
            var xPos = (square.XPos*texture.Width) + 10;
            var yPos = (square.YPos*texture.Width) + 10;

            var colour = _squareColourSelector.SelectColour(square);
      
            spriteBatch.Draw(texture, new Vector2(xPos, yPos), colour);
        }
    }
}